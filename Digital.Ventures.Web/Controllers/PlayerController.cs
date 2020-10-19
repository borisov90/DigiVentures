using AutoMapper;
using Digital.Ventures.Data.Core;
using Digital.Ventures.Data.Core.Domain;
using Digital.Ventures.Data.Core.Repositories;
using Digital.Ventures.Data.Persistance.Pagination;
using Digital.Ventures.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Digital.Ventures.Web.Controllers
{
    public class PlayerController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private readonly int pageSize = 10;

        public PlayerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult Players(int? pageNumber)
        {
            var players = _unitOfWork.Players.All();
            
            return View(PaginatedList<Player>.Create(players, pageNumber ?? 1, pageSize));

        }


        [HttpGet]
        public IActionResult CreatePlayer()
        {
            var model = new PlayerViewModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult SuccessfullyAdded(PlayerViewModel player)
        {
            return View(player);
        }

        [HttpGet]
        public IActionResult EditPlayer(Guid id)
        {
            Player player = this._unitOfWork.Players.GetByGuid(id);

            PlayerViewModel playerVm = _mapper.Map<PlayerViewModel>(player);

            return View(playerVm);
        }

        [HttpPost]
        public IActionResult UpdatePlayer(PlayerViewModel player)
        {
            Player updatedPlayer = _mapper.Map<Player>(player);

            _unitOfWork.Players.Update(updatedPlayer);

            _unitOfWork.SaveChanges();

            return View("SuccessfullyAdded", player);
        }

        [HttpPost]
        public IActionResult CreateNewPlayer(PlayerViewModel player)
        {
            Player newPlayer = _mapper.Map<Player>(player);

            try
            {
                _unitOfWork.Players.Add(newPlayer);

                _unitOfWork.SaveChanges();

                return View("SuccessfullyAdded", player);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }
        public IActionResult Search(string searchString)
        {
            var players = _unitOfWork.Players.Find(a => a.Name.Contains(searchString));

            PlayersViewModel playersVM = new PlayersViewModel() { };

            if (!String.IsNullOrEmpty(searchString))
            {
                playersVM = new PlayersViewModel() { Players = players };
            }

            return View("Search", playersVM);
        }
    }
}
using AutoMapper;
using Digital.Ventures.Data.Core.Domain;
using Digital.Ventures.Web.Models;

namespace Digital.Ventures.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Player, PlayerViewModel>();
            CreateMap<PlayerViewModel, Player>();
        }
    }
}

using Digital.Ventures.Data.Core.Domain;
using System.Collections.Generic;

namespace Digital.Ventures.Web.Models
{
    public class PlayersViewModel
    {
        public IEnumerable<Player> Players { get; set; }
    }
}

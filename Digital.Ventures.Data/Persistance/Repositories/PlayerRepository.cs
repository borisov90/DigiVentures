using Digital.Ventures.Data.Core.Domain;
using Digital.Ventures.Data.Core.Repositories;

namespace Digital.Ventures.Data.Persistance.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(DigitalVenturesDbContext context) : base(context)
        {
        }

        public DigitalVenturesDbContext DigitalVenturesDbContext
        {
            get { return _context as DigitalVenturesDbContext; }
        }
    }
}

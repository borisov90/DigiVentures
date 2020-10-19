using Digital.Ventures.Data.Core;
using Digital.Ventures.Data.Core.Repositories;
using Digital.Ventures.Data.Persistance.Repositories;
using System.Threading.Tasks;

namespace Digital.Ventures.Data.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DigitalVenturesDbContext _context;

        public UnitOfWork(DigitalVenturesDbContext context)
        {
            _context = context;
            Players = new PlayerRepository(_context);
        }

        public IPlayerRepository Players { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

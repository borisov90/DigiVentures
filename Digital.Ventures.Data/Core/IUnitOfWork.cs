using Digital.Ventures.Data.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Digital.Ventures.Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPlayerRepository Players { get; }
        int SaveChanges();
        Task SaveChangesAsync();
    }
}

using CQRS_.net_core.Application.Interfaces.Repositories;
using CQRS_.net_core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : IEntityBase,new();
        IWriteRepository<T> GetWriteRepository<T>() where T : IEntityBase,new();
        Task<int> SaveAsync();
        int Save();
    }
}

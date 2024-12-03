using CQRS_.net_core.Domain.Common;
using CQRS_.net_core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T>where T :IEntityBase,new()
    {
        Task AddAsync(T entity);

        Task AddRangeAsync(IList<T> entities);

        Task<T>UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entities);
    }
}

using CQRS_.net_core.Application.Interfaces.Repositories;
using CQRS_.net_core.Application.Interfaces.UnitOfWorks;
using CQRS_.net_core.Domain.Common;
using CQRS_.net_core.Persistence.Context;
using CQRS_.net_core.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);

        public int Save()=>dbContext.SaveChanges();

        public Task<int> SaveAsync() => dbContext.SaveChangesAsync();
    }
}

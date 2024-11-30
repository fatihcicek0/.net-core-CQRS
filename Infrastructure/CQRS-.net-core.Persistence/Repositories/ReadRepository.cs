﻿using CQRS_.net_core.Application.Interfaces.Repositories;
using CQRS_.net_core.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Persistence.Repositories
{
    public class ReadRepository<T> :IReadRepository<T> where T : IEntityBase,new()
    {
        private readonly DbContext dbContext;
        public ReadRepository(DbContext dbContext) {
              this.dbContext = dbContext;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }
        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy, bool enableTracking)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if(predicate is not null )queryable=queryable.Where(predicate);
            if(orderBy is not null)
                return await orderBy(queryable).ToListAsync();
            return await queryable.ToListAsync();
            }
        public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy, bool enableTracking, int currentPage, int pageSize)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).Skip((currentPage-1)*pageSize).Take(pageSize).ToListAsync();
            return await queryable.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }
         public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include, bool enableTracking)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
               queryable.Where(predicate);
            
            return await queryable.FirstOrDefaultAsync();
        }
        public async Task<int> GetCountAsync(Expression<Func<T, bool>>? predicate)
        {
            Table.AsNoTracking();
            if (predicate is not null) Table.Where(predicate);
            return await Table.CountAsync();
        }
        public  IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking) Table.AsNoTracking();
            return Table.Where(predicate);
        }

       

       

        
    }
    
}
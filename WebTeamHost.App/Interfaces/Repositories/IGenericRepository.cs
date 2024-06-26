﻿using Microsoft.Extensions.Caching.Distributed;
using WebTeamHost.Domain.Common.Interfaces;

namespace WebTeamHost.App.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        IQueryable<T> Entities { get; }

        Task<T> GetFromCacheById(int id, CancellationToken cancellationToken);

        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}

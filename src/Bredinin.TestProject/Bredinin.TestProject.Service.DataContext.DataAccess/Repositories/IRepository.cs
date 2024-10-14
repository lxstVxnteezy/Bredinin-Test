﻿namespace Bredinin.TestProject.DataContext.DataAccess.Repositories
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> Query { get; }

        TEntity GetById(Guid id);

        Task<TEntity> GetByIdAsync(Guid id, CancellationToken ctn);

        TEntity? FoundById(Guid id);

        Task<TEntity?> FoundByIdAsync(Guid id, CancellationToken ctn);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(TEntity[] entities);

        void RemoveById(Guid id);

        Task SaveChanges(CancellationToken ctn = default);
    }
}

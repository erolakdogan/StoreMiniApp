﻿using System.Linq.Expressions;

namespace StoreMiniApp.API.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task <T> GetByIdAsync(int id);
        Task <IEnumerable<T>> GetAllAsync();
        Task <IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        Task<T> FindByAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        void Remove (T entity);
        void Update(T entity);
    }
}

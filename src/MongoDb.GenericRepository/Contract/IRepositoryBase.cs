using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MongoDb.GenericRepository.Contract
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        void Update(Expression<Func<T, bool>> predicate, T entity);
        IEnumerable<T> GetAll();
        T GetSingle(Expression<Func<T, bool>> predicate);
        void Delete(Expression<Func<T, bool>> predicate);
    }
}

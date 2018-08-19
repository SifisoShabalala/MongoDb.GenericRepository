using MongoDb.GenericRepository.Contract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MongoDb.GenericRepository.Repository
{
    public class MongoRepository<T> : IRepositoryBase<T> where T : class
    {
        private readonly IDatabaseConnection<T> _connection;

        public MongoRepository(IDatabaseConnection<T> connection)
        {
            _connection = connection;
        }

        public void Add(T entity)
        {
            _connection.Collection.InsertOne(entity);
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            _connection.Collection.DeleteOne(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _connection.Collection.FindSync(Builders<T>.Filter.Empty).ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _connection.Collection.Find(predicate).FirstOrDefault();
        }

        public void Update(Expression<Func<T, bool>> predicate, T entity)
        {
          
        }
    }
}

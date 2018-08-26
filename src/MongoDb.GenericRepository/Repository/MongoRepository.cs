using MongoDb.GenericRepository.Contract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        public async Task AddAsync(T entity)
        {
            await _connection.Collection.InsertOneAsync(entity);
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            _connection.Collection.DeleteOne<T>(predicate);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            await _connection.Collection.DeleteOneAsync<T>(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _connection.Collection.FindSync<T>(Builders<T>.Filter.Empty).ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _connection.Collection.FindAsync<T>(Builders<T>.Filter.Empty).Result.ToListAsync();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _connection.Collection.Find<T>(predicate).FirstOrDefault();
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await _connection.Collection.FindAsync<T>(predicate).Result.FirstOrDefaultAsync();
        }

        public void Update(Expression<Func<T, bool>> predicate, T entity)
        {
            _connection.Collection.ReplaceOne<T>(predicate, entity);
        }

        public async Task UpdateAsync(Expression<Func<T, bool>> predicate, T entity)
        {
            await _connection.Collection.ReplaceOneAsync<T>(predicate, entity);
        }
    }
}

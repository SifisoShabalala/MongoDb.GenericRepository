using MongoDb.GenericRepository.Contract;
using MongoDB.Driver;

namespace MongoDb.GenericRepository.Database
{
    public class DatabaseConnection<T> : IDatabaseConnection<T> where T : class
    {
        private readonly IDatabaseSettings _settings;

        public DatabaseConnection(IDatabaseSettings settings)
        {
            _settings = settings;
            Init();
        }

        private void Init()
        {
            var client = new MongoClient(_settings.ConnectionString);
            var databse = client.GetDatabase(_settings.DatabaseName);
            Collection = databse.GetCollection<T>(_settings.TypeNameAsCollectionName ? typeof(T).Name : _settings.CollectionName);
        }

        public IMongoCollection<T> Collection { get; set; }
    }
}

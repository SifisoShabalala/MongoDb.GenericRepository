using MongoDb.GenericRepository.Contract;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace MongoDb.GenericRepository.Database
{
    public class DatabaseConnection<T> : IDatabaseConnection<T> where T : class
    {
        private readonly IDbConnection _connection;

        static DatabaseConnection()
        {
            BsonClassMap.RegisterClassMap<T>(x =>
            {
                x.AutoMap();
                x.MapIdField("Id").SetIgnoreIfDefault(true);
            });
        }

        public DatabaseConnection(IDbConnection connection)
        {
            _connection = connection;
            Init(ConnectionKey, DatabaseKey);
        }

        public void Init(string connectionKey, string databaseKey)
        {
            var connection = _connection.Connections[connectionKey];
            var database = connection.Databases[databaseKey];
            var client = new MongoClient(connection.ConnectionString);
            var databse = client.GetDatabase(database.Name);
            Collection = databse.GetCollection<T>(database.Collection?.Name);
            
            foreach(var key in database.Collection.IndexKeys)
            {
                
            }
        }

        public IMongoCollection<T> Collection { get; set; }
        public string ConnectionKey { get; set; }
        public string DatabaseKey { get; set; }
    }
}

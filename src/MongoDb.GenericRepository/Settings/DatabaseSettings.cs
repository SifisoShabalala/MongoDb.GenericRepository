using MongoDb.GenericRepository.Contract;

namespace MongoDb.GenericRepository.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string CollectionName { get; set; }
        public string DatabaseName { get; set; }
        public bool TypeNameAsCollectionName { get; set; }
    }
}

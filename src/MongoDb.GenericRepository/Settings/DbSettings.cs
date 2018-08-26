using System.Collections.Generic;
using MongoDb.GenericRepository.Contract;

namespace MongoDb.GenericRepository.Settings
{
    public class DbSettings : IDbSettings
    {
        public string ConnectionString { get; set; }
        public Dictionary<string, Db> Databases { get; set; }
    }
}

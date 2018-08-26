using MongoDb.GenericRepository.Settings;
using System.Collections.Generic;

namespace MongoDb.GenericRepository.Contract
{
    public interface IDbSettings
    {
        string ConnectionString { get; set; }
        Dictionary<string, Db> Databases { get; set; }
    }
}

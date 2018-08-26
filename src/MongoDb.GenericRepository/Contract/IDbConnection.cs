using MongoDb.GenericRepository.Settings;
using System.Collections.Generic;

namespace MongoDb.GenericRepository.Contract
{
    public interface IDbConnection
    {
        string ConnectionKey { get; set; }
        string DatabaseKey { get; set; }
        Dictionary<string, DbSettings> Connections { get; set; }
    }
}

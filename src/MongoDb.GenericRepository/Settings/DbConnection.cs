using System.Collections.Generic;

namespace MongoDb.GenericRepository.Settings
{
    public class DbConnection
    {
        public Dictionary<string, DbSettings> Connections { get; set; }
    }
}

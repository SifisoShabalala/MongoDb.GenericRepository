using System.Collections.Generic;

namespace MongoDb.GenericRepository.Settings
{
    public class DbCollection
    {
        public string Name { get; set; }
        public List<string> IndexKeys { get; set; }
    }
}

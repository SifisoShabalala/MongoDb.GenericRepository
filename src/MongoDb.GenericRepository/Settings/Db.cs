using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDb.GenericRepository.Settings
{
    public class Db
    {
        public string Name { get; set; }
        public DbCollection Collection { get; set; }
    }
}

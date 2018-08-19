using MongoDB.Driver;

namespace MongoDb.GenericRepository.Contract
{
    public interface IDatabaseConnection<T> where T : class
    {
        IMongoCollection<T> Collection { get; set; }
    }
}

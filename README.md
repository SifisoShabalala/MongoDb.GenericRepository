A generic MongoDb repository.

Example usage:

using MongoDb.GenericRepository.Database;
using MongoDb.GenericRepository.Repository;
using MongoDb.GenericRepository.Settings;
using MongoDB.Bson;

namespace MongoDb.GenericRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new DatabaseSettings
            {
                ConnectionString = "mongodb://localhost",
                DatabaseName = "people",
                CollectionName = "person",
                TypeNameAsCollectionName = false
            };
            var connection = new DatabaseConnection<Person>(settings);
            var repository = new MongoRepository<Person>(connection);

            repository.Add(new Person {
					Name = "Test" });
        }

        class Person
        {
            public ObjectId Id { get; set; }
            public string Name { get; set; }
        }
    }
}

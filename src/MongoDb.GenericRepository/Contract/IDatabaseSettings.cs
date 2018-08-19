namespace MongoDb.GenericRepository.Contract
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }
        bool TypeNameAsCollectionName { get; set; }
    }
}

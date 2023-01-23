using MongoDB.Driver;

namespace Ecommerce.Infra.Context;
public class AppDbContext
{
    private readonly IMongoDatabase _database;
    public AppDbContext(IOptions<MongoDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        _database = client.GetDatabase(settings.Value.Database);
    }

    public IMongoCollection<MyModel> MyModels => _database.GetCollection<MyModel>("MyModel");
}

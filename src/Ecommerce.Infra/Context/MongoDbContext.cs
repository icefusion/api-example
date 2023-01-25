using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infra.Context;

public class MongoDbContext : DbContext
{
    public MongoDbContext(DbContextOptions<MongoDbContext> options) : base(options) {}

    // IOptions<MongoDbSettings> settings
    // public PostgreDbContext(IOptions<PostgreDbSettings> settings) {}
    
    // private readonly IMongoDatabase _database;
    // public AppDbContext(IOptions<MongoDbSettings> settings)
    // {
    //     var client = new MongoClient(settings.Value.ConnectionString);
    //     _database = client.GetDatabase(settings.Value.Database);
    // }

    // public IMongoCollection<MyModel> MyModels => _database.GetCollection<MyModel>("MyModel");

    // public class MyDbContext : DbContext
    // {
    //     public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    //     //Add your DbSet properties here
    //     public DbSet<MyEntity> MyEntities { get; set; }
    // }
}


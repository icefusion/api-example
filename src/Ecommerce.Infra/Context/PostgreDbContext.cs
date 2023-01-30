using Microsoft.EntityFrameworkCore;
using Ecommerce.Infra.Settings;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Infra.Context;

public class PostgreDbContext : DbContext
{
    public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        PostgreDbSettings configs = new PostgreDbSettings();

        string stringConnection = $"Server={configs.Host};Port={configs.Port};Database={configs.DatabaseName};User Id={configs.User};Password={configs.Password};";
        
        optionsBuilder.UseNpgsql(stringConnection);
    }

    public DbSet<Product> Product { get; set; }
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

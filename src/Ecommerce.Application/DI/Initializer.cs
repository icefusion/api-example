using Ecommerce.Domain.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Repositories;
using Ecommerce.Domain.Services;
using Ecommerce.Infra.Context;
using Ecommerce.Infra.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Application.DI {
    public class Initializer {
        public static void Configure (IServiceCollection services) 
        {
            // services.AddDbContext<PostgreDbContext>(options => PostgreDbSettings);
            services.AddScoped (typeof (IRepository<Product>), typeof (ProductRepository));
            services.AddScoped (typeof (IRepository<>), typeof (Repository<>));
            services.AddScoped (typeof (ProductsService));
        }
    }
}

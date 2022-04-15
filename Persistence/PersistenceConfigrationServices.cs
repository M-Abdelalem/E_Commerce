using Application.Contract.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;


namespace Persistence
{
    static public  class PersistenceConfigrationServices
    {
        public static IServiceCollection PersistenceConfigure(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<E_CommerceDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("EcommerceConnection")));
            service.AddScoped<IProductBrandRepository, ProductBrandRepository>();
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IProductBrandRepository, ProductBrandRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped(typeof(Irepository<>), typeof(Repository<>));
            return service;
        }
    }
}
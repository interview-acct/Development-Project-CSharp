using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Interview.Database.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Interview.Database
{
    public static class DatabaseServiceCollectionExtension
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfigurationSection configSection)
        {
            services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlServer(
                    configSection["ConnectionString"]
                )
            );

            services.AddDbContext<TransactionDbContext>(options =>
                options.UseSqlServer(
                    configSection["ConnectionString"]
                )
            );

            return services;
        }
    }
}

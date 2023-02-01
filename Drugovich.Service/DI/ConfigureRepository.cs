using Drugovich.Data.Context;
using Drugovich.Data.implementation;
using Drugovich.Data.Repository;
using Drugovich.Domain.Interfaces.Repository;
using Drugovich.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Drugovich.Service.DI
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUsuarioRepository, UsuarioImplementation>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnetion");
            var optionsBuilder = new DbContextOptionsBuilder<DrugovichContext>();
            serviceCollection.AddDbContext<DrugovichContext>(
                options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 22)))
            );
        }
    }
}

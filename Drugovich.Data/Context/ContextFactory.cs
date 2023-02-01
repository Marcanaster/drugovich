using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Drugovich.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<DrugovichContext>
    {
        public DrugovichContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnetion");
            var optionsBuilder = new DbContextOptionsBuilder<DrugovichContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 22)));
            return new DrugovichContext(optionsBuilder.Options);
        }
    }
}

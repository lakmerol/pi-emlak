using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public static class AppDbService
    {
        public static IServiceCollection ImplementPersistence(this
            IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("secret.json", optional: true, reloadOnChange: true)
        .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection")),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<IDbContext>(provider =>
            provider.GetService<ApplicationDbContext>());

            return services;
        }
    }
}

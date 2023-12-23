using AutoMapper;
using BLL.Common;
using DAL.Configurations;
using DAL.Entities;
using DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Configurations
{
    public  static class ServiceCollection
    {
        public static void AddTest(this IServiceCollection services)
        {
            
            services.AddScoped<IRepository<Agent>, AgentRepository>();
            services.AddScoped<IRepository<Estate>, EstateRepository>();
            services.AddScoped<IRepository<Customer>, CustomerRepository>();
            services.AddScoped<IControlRepository<Agent>, AgentRepository>();
            services.AddScoped<IControlRepository<Customer>, CustomerRepository>();
            services.ImplementPersistence();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}

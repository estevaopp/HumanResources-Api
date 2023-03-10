using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResources.Infra.CrossCutting.DependencyInjection
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDbConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"), b => 
                    b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );

            return services;
        }
    }
}
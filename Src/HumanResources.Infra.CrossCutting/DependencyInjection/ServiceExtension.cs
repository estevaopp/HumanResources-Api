using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResources.Infra.CrossCutting.DependencyInjection
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // services.AddScoped<IMapperService, MapperService>();
            
            return services;
        }
    }
}
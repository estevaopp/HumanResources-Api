using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Application.Interfaces;
using HumanResources.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResources.Infra.CrossCutting.DependencyInjection
{
    public static class MapperExtension
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            services.AddScoped<IMapperService, MapperService>();
            
            return services;
        }
    }
}
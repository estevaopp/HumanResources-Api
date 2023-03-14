using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Interfaces.Repositories;
using HumanResources.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResources.Infra.CrossCutting.DependencyInjection
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeEntityRepository, EmployeeEntityRepository>();
            services.AddScoped<IHcmEmployeeRoleEntityRepository, HcmEmployeeRoleEntityRepository>();
            services.AddScoped<IHcmPersonDetailEntityRepository, HcmPersonDetailEntityRepository>();

            return services;
        }
    }
}
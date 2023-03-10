using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;
using HumanResources.Domain.Interfaces.Repositories;
using HumanResources.Infra.Data.Context;

namespace HumanResources.Infra.Data.Repositories
{
    public class EmployeeEntityRepository : Repository<EmployeeEntity>, IEmployeeEntityRepository
    {
        public EmployeeEntityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;
using HumanResources.Domain.Interfaces.Repositories;
using HumanResources.Infra.Data.Context;

namespace HumanResources.Infra.Data.Repositories
{
    public class HcmEmployeeRoleEntityRepository : Repository<HcmEmployeeRoleEntity>, IHcmEmployeeRoleEntityRepository
    {
        public HcmEmployeeRoleEntityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;
using HumanResources.Domain.Interfaces.Repositories;
using HumanResources.Infra.Data.Context;

namespace HumanResources.Infra.Data.Repositories
{
    public class HcmPersonDetailEntityRepository : Repository<HcmPersonDetailEntity>, IHcmPersonDetailEntityRepository
    {
        public HcmPersonDetailEntityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
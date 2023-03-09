using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Repositories
{
    public interface IHcmPersonDetailEntityRepository
    {
        
        Task<IEnumerable<HcmPersonDetailEntity>> GetAll();

        Task<HcmPersonDetailEntity> GetById(int id);

        Task Add(HcmPersonDetailEntity hcmPersonDetailEntity);

        Task Delete(HcmPersonDetailEntity hcmPersonDetailEntity);

        Task Update(HcmPersonDetailEntity hcmPersonDetailEntity);
    }
}
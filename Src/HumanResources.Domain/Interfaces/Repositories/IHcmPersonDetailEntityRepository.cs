using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Repositories
{
    public interface IHcmPersonDetailEntityRepository
    {
        
        Task<HcmPersonDetailEntity> GetAll();

        Task<HcmPersonDetailEntity> GetById(int id);

        Task<HcmPersonDetailEntity> Add(HcmPersonDetailEntity hcmPersonDetailEntity);

        Task<HcmPersonDetailEntity> Delete(HcmPersonDetailEntity hcmPersonDetailEntity);

        Task<HcmPersonDetailEntity> Update(HcmPersonDetailEntity hcmPersonDetailEntity);
    }
}
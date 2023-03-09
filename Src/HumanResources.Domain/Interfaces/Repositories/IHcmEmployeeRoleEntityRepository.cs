using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Repositories
{
    public interface IHcmEmployeeRoleEntityRepository
    {
        Task<IEnumerable<HcmEmployeeRoleEntity>> GetAll();

        Task<HcmEmployeeRoleEntity> GetById(int id);

        Task Add(HcmEmployeeRoleEntity hcmEmployeeRoleEntity);

        Task Delete(HcmEmployeeRoleEntity hcmEmployeeRoleEntity);

        Task Update(HcmEmployeeRoleEntity hcmEmployeeRoleEntity);
    }
}
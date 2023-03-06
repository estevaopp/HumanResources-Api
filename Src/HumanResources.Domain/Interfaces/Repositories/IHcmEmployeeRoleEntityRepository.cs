using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Repositories
{
    public interface IHcmEmployeeRoleEntityRepository
    {
        Task<HcmEmployeeRoleEntity> GetAll();

        Task<HcmEmployeeRoleEntity> GetById(int id);

        Task<HcmEmployeeRoleEntity> Add(HcmEmployeeRoleEntity hcmEmployeeRoleEntity);

        Task<HcmEmployeeRoleEntity> Delete(HcmEmployeeRoleEntity hcmEmployeeRoleEntity);

        Task<HcmEmployeeRoleEntity> Update(HcmEmployeeRoleEntity hcmEmployeeRoleEntity);
    }
}
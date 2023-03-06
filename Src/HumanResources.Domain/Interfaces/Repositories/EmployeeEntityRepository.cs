using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Repositories
{
    public interface EmployeeEntityRepository
    {
        Task<EmployeeEntity> GetAll();

        Task<EmployeeEntity> GetById(int id);

        Task<EmployeeEntity> Add(EmployeeEntity employeeEntity);

        Task<EmployeeEntity> Delete(EmployeeEntity employeeEntity);

        Task<EmployeeEntity> Update(EmployeeEntity employeeEntity);
    }
}
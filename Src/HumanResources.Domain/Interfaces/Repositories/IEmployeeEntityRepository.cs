using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Repositories
{
    public interface IEmployeeEntityRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetAll();

        Task<EmployeeEntity> GetById(int id);

        Task Add(EmployeeEntity employeeEntity);

        Task Delete(EmployeeEntity employeeEntity);

        Task Update(EmployeeEntity employeeEntity);
    }
}
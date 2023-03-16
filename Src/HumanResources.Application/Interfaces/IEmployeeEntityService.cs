using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Application.ViewModel.Request;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Application.Interfaces
{
    public interface IEmployeeEntityService
    {
        public Task<EmployeeEntity> Add(EmployeeEntityRequestViewModel employeeRequest);
        public Task<EmployeeEntity> Update(int id, EmployeeEntityRequestViewModel employeeRequest);
        public Task<EmployeeEntity> Delete(int id);
        public Task<List<EmployeeEntity>> GetAll();
        public Task<EmployeeEntity> GetById(int id);
    }
}
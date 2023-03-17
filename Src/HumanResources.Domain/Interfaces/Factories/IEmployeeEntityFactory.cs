using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Interfaces.Factories
{
    public interface IEmployeeEntityFactory
    {
        public EmployeeEntity CreateEmployee(int HcmEmployeeRoleEntityId);
    }
}
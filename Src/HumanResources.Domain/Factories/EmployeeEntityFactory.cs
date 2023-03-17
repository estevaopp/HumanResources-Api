using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.EmployeeParents;
using HumanResources.Domain.Entities.Employees;
using HumanResources.Domain.Interfaces.Factories;

namespace HumanResources.Domain.Factories
{
    public class EmployeeEntityFactory : IEmployeeEntityFactory
    {
        public EmployeeEntity CreateEmployee(int HcmEmployeeRoleEntityId)
        {
            var factory = EmployeeFactiories[HcmEmployeeRoleEntityId];

            return factory();
        }

        public static Dictionary<int, Func<EmployeeEntity>> EmployeeFactiories = new Dictionary<int, Func<EmployeeEntity>>
        {
            {1, () => new CookEmployee()},
            {2, () => new CashierEmployee()},
            {3, () => new KitchenAssistantEmployee()}
        };
    }
}
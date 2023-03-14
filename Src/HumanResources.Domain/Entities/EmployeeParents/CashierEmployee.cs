using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Entities.EmployeeParents
{
    public class CashierEmployee : EmployeeEntity
    {
        public override void DismissEmployee()
        {
            throw new NotImplementedException();
        }

        public override void Payroll()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Caixa";
        }
    }
}
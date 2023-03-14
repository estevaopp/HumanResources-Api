using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Domain.Entities.EmployeeParents
{
    public class CookEmployee : EmployeeEntity
    {
        public override void DismissEmployee()
        {
            System.Console.WriteLine("Demitindo um cozinheiro");
        }

        public override void Payroll()
        {
            System.Console.WriteLine("Pagando um cozinheiro");
        }

        public override string ToString()
        {
            return "Cozinheiro";
        }
    }
}
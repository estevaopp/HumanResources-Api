using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities.Employees
{
     public abstract class EmployeeEntity : EntityBase
    {
        public virtual HcmPersonDetailEnity HcmPersonDetailEnity { get; }
        public virtual HcmEmployeeRole HcmEmployeeRole { get; }
        public virtual PayrollSalary PayrollSalary { get; }
        public string Email { get; }
        public int HcmEmployeeStatusId { get; }
        public virtual HcmEmployeeStatus HcmEmployeeStatus { get; }


        public abstract void Payroll();
        public abstract void DismissEmployee();
        public abstract void MissWork();
    }
}
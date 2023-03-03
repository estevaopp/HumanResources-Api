using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResources.Domain.Entities.Employees
{
     public abstract class EmployeeEntity : EntityBase
    {
        public virtual HcmPersonDetailEntity HcmPersonDetailEntity { get; }
        public virtual HcmEmployeeRoleEntity HcmEmployeeRoleEntity { get; }
        public virtual PayrollSalaryEntity PayrollSalaryEntity { get; }
        public string Email { get; }
        public int HcmEmployeeStatusId { get; }
        public virtual HcmEmployeeStatusEntity HcmEmployeeStatusEntity { get; }


        public abstract void Payroll();
        public abstract void DismissEmployee();
        public abstract void MissWork();
    }
}
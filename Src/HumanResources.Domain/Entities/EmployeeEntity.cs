using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Entities.Employees
{
     public abstract class EmployeeEntity : EntityBase
    {
        public virtual HcmPersonDetailEntity HcmPersonDetailEntity { get; }
        public virtual HcmEmployeeSeniorityEntity HcmEmployeeSeniorityEntity { get; }
        public virtual PayrollSalaryEntity PayrollSalaryEntity { get; }
        public EmployeeStatusEnum EmployeeStatus { get; private set; }
        public DateOnly EmploymentStartDate { get; private set; }
        public DateOnly EmploymentEndDate { get; private set; }
        
        public EmployeeEntity()
        {
            
        }

        public abstract void Payroll();
        public abstract void DismissEmployee();
        public void MissWork()
        {
            EmploymentEndDate = DateOnly.FromDateTime(DateTime.UtcNow.AddHours(-3));
            EmployeeStatus = EmployeeStatusEnum.Dismiss;
        }
        public void MissWork(DateOnly employmentEndDate)
        {
            EmploymentEndDate = employmentEndDate;
            EmployeeStatus = EmployeeStatusEnum.Dismiss;
        }
    }
}
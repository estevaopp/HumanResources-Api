using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Entities.Employees
{
     public abstract class EmployeeEntity : EntityBase
    {
        public decimal MonthlySalaryFixed { get; private set; }

        public decimal MonthlySalaryVariable { get; private set; }

        public EmployeeStatusEnum EmployeeStatus { get; private set; }

        public DateOnly EmploymentStartDate { get; private set; }

        public DateOnly EmploymentEndDate { get; private set; }

        public EmployeeSeniorityEnum EmployeeSeniority { get; private set; }

        public int HcmEmployeeRoleEntityId { get; private set; }

        public virtual HcmEmployeeRoleEntity HcmEmployeeRoleEntity { get; }

        public virtual HcmPersonDetailEntity HcmPersonDetailEntity { get; }
        

        protected EmployeeEntity() { }

        public EmployeeEntity(int hcmEmployeeRoleEntityId, decimal monthlySalaryFixed, decimal monthlySalaryVariable, EmployeeStatusEnum employeeStatus, DateOnly employmentStartDate, DateOnly employmentEndDate, EmployeeSeniorityEnum employeeSeniority)
        {
            HcmEmployeeRoleEntityId = hcmEmployeeRoleEntityId;
            MonthlySalaryFixed = monthlySalaryFixed;
            MonthlySalaryVariable = monthlySalaryVariable;
            EmployeeStatus = employeeStatus;
            EmploymentStartDate = employmentStartDate;
            EmploymentEndDate = employmentEndDate;
            EmployeeSeniority = employeeSeniority;
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
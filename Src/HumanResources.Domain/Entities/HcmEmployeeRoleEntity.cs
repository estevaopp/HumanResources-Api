using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Entities.Employees
{
    public class HcmEmployeeRoleEntity : EntityBase
    {
        public string Name { get; set; }
        public EmployeeSeniorityEnum EmployeeSeniority { get; private set; }


        protected HcmEmployeeRoleEntity(){ }

        public HcmEmployeeRoleEntity(string name, EmployeeSeniorityEnum employeeSeniority)
        {
            Name = name;
            EmployeeSeniority = employeeSeniority;
        }
    }
}
using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Entities.Employees
{
    public class HcmEmployeeRoleEntity : EntityBase
    {
        public string Name { get; private set; }

        public virtual List<EmployeeEntity> Employees { get; private set; }


        protected HcmEmployeeRoleEntity(){ }

        public HcmEmployeeRoleEntity(string name)
        {
            Name = name;
        }
    }
}
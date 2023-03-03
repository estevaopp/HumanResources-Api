using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Entities.Employees
{
    public class HcmPersonDetailEntity : EntityBase
    {
        public int EmployeeEntityId { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string CellPhoneNumber { get; }
        public string Cpf { get; }
        public DateOnly Birthdate { get; }
        public GenderEnum Gender { get; }

        public HcmPersonDetailEntity()
        {
            
        }
    }
}
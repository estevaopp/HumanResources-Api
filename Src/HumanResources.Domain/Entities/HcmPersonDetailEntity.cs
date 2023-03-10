using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Entities.Employees
{
    public class HcmPersonDetailEntity : EntityBase
    {
        public int EmployeeEntityId { get; private set; }
        
        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string CellPhoneNumber { get; private set; }

        public string Cpf { get; private set; }

        public DateOnly Birthdate { get; private set; }

        public GenderEnum Gender { get; private set; }

        public virtual EmployeeEntity EmployeeEntity { get; }

        protected HcmPersonDetailEntity() { }

        public HcmPersonDetailEntity(int employeeEntityId, string firstName, string middleName, string lastName, string email, string cellPhoneNumber, string cpf, DateOnly birthdate, GenderEnum gender)
        {
            EmployeeEntityId = employeeEntityId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            CellPhoneNumber = cellPhoneNumber;
            Cpf = cpf;
            Birthdate = birthdate;
            Gender = gender;
        }
    }
}
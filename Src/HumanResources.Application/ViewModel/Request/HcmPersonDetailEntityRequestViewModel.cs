using System.ComponentModel.DataAnnotations;
using HumanResources.Domain.Enums;

namespace HumanResources.Application.ViewModel.Request
{
    public class HcmPersonDetailEntityRequestViewModel
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int EmployeeEntityId { get; set; }
        

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string MiddleName { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string CellPhoneNumber { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cpf { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateOnly Birthdate { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public GenderEnum Gender { get; set; }
        
        
        public HcmPersonDetailEntityRequestViewModel(int employeeEntityId, string firstName, string middleName, string lastName, string email, string cellPhoneNumber, string cpf, DateOnly birthdate, GenderEnum gender)
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
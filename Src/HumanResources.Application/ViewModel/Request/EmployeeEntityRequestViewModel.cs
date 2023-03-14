using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Enums;

namespace HumanResources.Application.ViewModel.Request
{
    public class EmployeeEntityRequestViewModel
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal MonthlySalaryFixed { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal MonthlySalaryVariable { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public EmployeeStatusEnum EmployeeStatus { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateOnly EmploymentStartDate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateOnly EmploymentEndDate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public EmployeeSeniorityEnum EmployeeSeniority { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int HcmEmployeeRoleEntityId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public HcmPersonDetailEntityRequestViewModel HcmPersonDetailEntity { get; set; }
    }
}
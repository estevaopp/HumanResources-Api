using System.ComponentModel;

namespace HumanResources.Domain.Enums
{
    public enum EmployeeStatusEnum
    {
        [Description("Trabalhando")]
        Working = 1,
        [Description("Férias")]
        Vacation = 2,
        [Description("Demitido")]
        Dismiss = 3,
        [Description("Licença Maternidade")]
        MaternityLeave = 4,
        
        [Description("Atestado Médico")]
        MedicalCertificate = 5

    }
}
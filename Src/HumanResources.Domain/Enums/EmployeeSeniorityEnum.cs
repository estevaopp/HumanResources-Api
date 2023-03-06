using System.ComponentModel;

namespace HumanResources.Domain.Enums
{
    public enum EmployeeSeniorityEnum
    {
        [Description("Junior")]
        Junior = 1,
        [Description("Pleno")]
        Mid = 2,
        [Description("Senior")]
        Senior = 3,
        [Description("Especialista")]
        Specialist = 4
    }
}
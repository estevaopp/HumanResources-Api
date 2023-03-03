using System.ComponentModel;

namespace HumanResources.Domain.Enums
{
    public enum GenderEnum
    {
        [Description("Masculino")]
        Male = 1,

        [Description("Feminino")]
        Female = 2,

        [Description("Prefiro não dizer")]
        NoneDeclare = 3
    }
}
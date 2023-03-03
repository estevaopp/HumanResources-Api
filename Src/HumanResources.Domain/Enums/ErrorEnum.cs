using System.ComponentModel;

namespace HumanResources.Domain.Enums
{
    public enum ErrorEnum
    {
        [Description("Not found")]
        ResourceNotFound = 1,

        [Description("Invalid field")]
        ResourceInvalidField = 2,

        [Description("Bad request")]
        ResourceBadRequest = 3
    }
}
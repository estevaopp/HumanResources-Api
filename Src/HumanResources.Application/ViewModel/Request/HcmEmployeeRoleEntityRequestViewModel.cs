using HumanResources.Domain.Enums;

namespace HumanResources.Application.ViewModel.Request
{
    public class HcmEmployeeRoleEntityRequestViewModel
    {
        public string Name { get; private set; }

        public HcmEmployeeRoleEntityRequestViewModel(string name)
        {
            Name = name;
        }
    }
}
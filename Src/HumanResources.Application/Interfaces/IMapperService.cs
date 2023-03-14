using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Application.ViewModel.Request;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Application.Interfaces
{ 
    public interface IMapperService
    {
        EmployeeEntity Map(EmployeeEntityRequestViewModel source);
        HcmPersonDetailEntity Map(HcmPersonDetailEntityRequestViewModel source);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Application.Interfaces;
using HumanResources.Application.ViewModel.Request;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Application.Mappers
{

    public class MapperService : IMapperService
    {
        public EmployeeEntity Map(EmployeeEntityRequestViewModel source)
        {
            EmployeeEntity mappedObject = new EmployeeEntity
            (
                source.HcmEmployeeRoleEntityId,
                source.MonthlySalaryFixed,
                source.MonthlySalaryVariable,
                source.EmployeeStatus,
                source.EmploymentStartDate,
                source.EmploymentEndDate,
                source.EmployeeSeniority
            );

            return mappedObject;
        }

        public HcmPersonDetailEntity Map(HcmPersonDetailEntityRequestViewModel source)
        {
            HcmPersonDetailEntity mappedObject = new HcmPersonDetailEntity
            (
                source.EmployeeEntityId,
                source.FirstName,
                source.MiddleName,
                source.LastName,
                source.Email,
                source.CellPhoneNumber,
                source.Cpf,
                source.Birthdate,
                source.Gender
            );

            return mappedObject;
        }
    }
}
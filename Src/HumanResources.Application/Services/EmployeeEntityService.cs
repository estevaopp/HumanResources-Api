using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Application.Interfaces;
using HumanResources.Application.ViewModel.Request;
using HumanResources.Domain.Entities.Employees;
using HumanResources.Domain.Interfaces.Repositories;

namespace HumanResources.Application.Services
{
    public class EmployeeEntityService : IEmployeeEntityService
    {
        private readonly IEmployeeEntityRepository _employeeRepository;
        private readonly IMapperService _mapperService;

        public EmployeeEntityService(IEmployeeEntityRepository employeeRepository, IMapperService mapperService)
        {
            _employeeRepository = employeeRepository;
            _mapperService = mapperService;
        }

        public async Task<EmployeeEntity> Add(EmployeeEntityRequestViewModel employeeRequest)
        {
            var employeeEntity = _mapperService.Map(employeeRequest);

            await _employeeRepository.Add(employeeEntity);

            return employeeEntity;
        }

        public async Task<EmployeeEntity> Delete(int id)
        {
            var employeeEntity = await _employeeRepository.GetById(id);

            await _employeeRepository.Delete(employeeEntity);

            return employeeEntity;
        }

        public async Task<List<EmployeeEntity>> GetAll()
        {
            return (List<EmployeeEntity>) await _employeeRepository.GetAll();
        }

        public async Task<EmployeeEntity> GetById(int id)
        {
            var employeeEntity = await _employeeRepository.GetById(id);

            return employeeEntity;
        }

        public async Task<EmployeeEntity> Update(int id, EmployeeEntityRequestViewModel employeeRequest)
        {
            var employeeEntity = await _employeeRepository.GetById(id);

            employeeEntity.Update(employeeRequest.HcmEmployeeRoleEntityId, employeeRequest.MonthlySalaryFixed, employeeRequest.MonthlySalaryVariable, employeeRequest.EmployeeStatus, employeeRequest.EmploymentStartDate, employeeRequest.EmploymentEndDate, employeeRequest.EmployeeSeniority);

            await _employeeRepository.Update(employeeEntity);

            return employeeEntity;
        }
    }
}
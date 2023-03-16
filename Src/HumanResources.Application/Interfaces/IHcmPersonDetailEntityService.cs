using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Application.ViewModel.Request;
using HumanResources.Domain.Entities.Employees;

namespace HumanResources.Application.Interfaces
{
    public interface IHcmPersonDetailEntityService
    {
        public Task<HcmPersonDetailEntity> Add(HcmPersonDetailEntityRequestViewModel employeeRequest);
        public Task<HcmPersonDetailEntity> Update(int id, HcmPersonDetailEntityRequestViewModel employeeRequest);
        public Task<HcmPersonDetailEntity> Delete(int id);
        public Task<List<HcmPersonDetailEntity>> GetAll();
        public Task<HcmPersonDetailEntity> GetById(int id);
    }
}
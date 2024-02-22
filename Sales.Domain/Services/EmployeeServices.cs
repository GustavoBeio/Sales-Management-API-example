using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        async Task<Response> IEmployeeServices.CreateAsync(EmployeeModel employee)
        {
            var response = new Response();
            var validation = new EmployeeValidation();
            var errors = validation.Validate(employee).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _employeeRepository.CreateAsync(employee);
            return response;
        }

        Task<Response<bool>> IEmployeeServices.AuthAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        async Task<Response> IEmployeeServices.UpdateAsync(EmployeeModel employee)
        {
            var response = new Response();
            var validation = new EmployeeValidation();
            var errors = validation.Validate(employee).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _employeeRepository.CreateAsync(employee);
            return response;
        }

        Task<Response> IEmployeeServices.DeleteAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        Task<Response<EmployeeModel>> IEmployeeServices.GetbyIdAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        Task<Response<List<EmployeeModel>>> IEmployeeServices.ListbyFilterAsync(string employeeId, string name)
        {
            throw new NotImplementedException();
        }
    }
}

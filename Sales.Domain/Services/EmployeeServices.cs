using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Services
{
    public class EmployeeServices(IEmployeeRepository employeeRepository) : IEmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository;

        async Task<Response> IEmployeeServices.CreateAsync(EmployeeModel employee)
        {
            Response response = new();
            EmployeeValidation validation = new();
            var errors = validation.Validate(employee).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            await _employeeRepository.CreateAsync(employee);
            return response;
        }

        Task<Response<bool>> IEmployeeServices.AuthAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        async Task<Response> IEmployeeServices.UpdateAsync(EmployeeModel employee)
        {
            Response response = new();
            EmployeeValidation validation = new();
            var errors = validation.Validate(employee).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _employeeRepository.CreateAsync(employee);
            return response;
        }

        async Task<Response> IEmployeeServices.DeleteAsync(string employeeId)
        {
            Response response = new();

            if (!await _employeeRepository.ExistsbyIdAsync(employeeId))
            {
                response.Report.Add(Report.Create($"employee {employeeId} does not exists."));
                return response;
            }
            await _employeeRepository.DeleteAsync(employeeId);
            return response;
        }

        async Task<Response<EmployeeModel>> IEmployeeServices.GetbyIdAsync(string employeeId)
        {
            Response<EmployeeModel> response = new();

            if (!await _employeeRepository.ExistsbyIdAsync(employeeId))
            {
                response.Report.Add(Report.Create($"employee {employeeId} does not exists."));
                return response;
            }
            response.Data = await _employeeRepository.GetbyIdAsync(employeeId);
            return response;
        }

        async Task<Response<List<EmployeeModel>>> IEmployeeServices.ListbyFilterAsync(string employeeId, string name)
        {
            Response<List<EmployeeModel>> response = new();
            if (!string.IsNullOrEmpty(employeeId))
            {
                if (!await _employeeRepository.ExistsbyIdAsync(employeeId))
                {
                    response.Report.Add(Report.Create($"employee `{employeeId} does not exists"));
                    return response;
                }
            }
            response.Data = await _employeeRepository.ListbyFilterAsync(employeeId, name);
            return response;
        }
    }
}

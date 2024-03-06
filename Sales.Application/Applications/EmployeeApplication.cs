using AutoMapper;
using Sales.Application.DataContract.Request.Employee;
using Sales.Application.Interfaces;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Applications
{
    public class EmployeeApplication(IEmployeeServices employeeService, IMapper mapper) : IEmployeeApplication
    {
        private readonly IEmployeeServices _employeeService = employeeService;
        private readonly IMapper _mapper = mapper;

        async Task<Response<bool>> IEmployeeApplication.AuthSync(AuthEmployeeRequest authEmployeeRequest)
        {
            return await _employeeService.AuthAsync(_mapper.Map<EmployeeModel>(authEmployeeRequest));
        }

        async Task<Response> IEmployeeApplication.CreateAsync(CreateEmployeeRequest reateEmployeeRequest)
        {
            return await _employeeService.CreateAsync(_mapper.Map<EmployeeModel>(reateEmployeeRequest));
        }

        async Task<Response> IEmployeeApplication.DeleteAsync(string employeeId)
        {
            return await _employeeService.DeleteAsync(employeeId);
        }

        async Task<Response<EmployeeModel>> IEmployeeApplication.GetByIdAsync(string employeeId)
        {
            return await _employeeService.GetbyIdAsync(employeeId);
        }

        async Task<Response<List<EmployeeModel>>> IEmployeeApplication.ListbyFilterAsync(string employeeId, string name)
        {
            return await _employeeService.ListbyFilterAsync(employeeId, name);
        }

        async Task<Response> IEmployeeApplication.UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest)
        {
            return await _employeeService.UpdateAsync(_mapper.Map<EmployeeModel>(updateEmployeeRequest));
        }
    }
}

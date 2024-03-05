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
        async Task<Response> IEmployeeApplication.CreateAsync(CreateEmployeeRequest employee)
        {
            return await _employeeService.CreateAsync(_mapper.Map<EmployeeModel>(employee));
        }
    }
}

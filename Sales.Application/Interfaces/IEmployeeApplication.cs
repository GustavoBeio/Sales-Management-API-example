using Sales.Application.DataContract.Request.Employee;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Interfaces
{
    public interface IEmployeeApplication
    {
        Task<Response<bool>> AuthSync(AuthEmployeeRequest authEmployeeRequest);
        Task<Response> CreateAsync(CreateEmployeeRequest createEmployeeRequest);
        Task<Response> UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest);
        Task<Response> DeleteAsync(string employeeId);
        Task<Response<EmployeeModel>> GetByIdAsync(string employeeId);
        Task<Response<List<EmployeeModel>>> ListbyFilterAsync(string employeeId, string name);
    }
}

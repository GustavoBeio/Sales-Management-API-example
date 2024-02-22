using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IEmployeeServices
    {
        Task<Response<bool>> AuthAsync(EmployeeModel employee);
        Task<Response> CreateAsync(EmployeeModel employee);
        Task<Response> UpdateAsync(EmployeeModel employee);
        Task<Response> DeleteAsync(string employeeId);
        Task<Response<EmployeeModel>> GetbyIdAsync(string employeeId);
        Task<Response<List<EmployeeModel>>> ListbyFilterAsync(string employeeId, string name);
    }
}

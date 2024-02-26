using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IEmployeeServices
    {
        public Task<Response<bool>> AuthAsync(EmployeeModel employee);
        public Task<Response> CreateAsync(EmployeeModel employee);
        public Task<Response> UpdateAsync(EmployeeModel employee);
        public Task<Response> DeleteAsync(string employeeId);
        public Task<Response<EmployeeModel>> GetbyIdAsync(string employeeId);
        public Task<Response<List<EmployeeModel>>> ListbyFilterAsync(string employeeId, string name);
    }
}

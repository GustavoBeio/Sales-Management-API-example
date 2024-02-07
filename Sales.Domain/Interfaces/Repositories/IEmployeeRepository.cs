using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task CreateAsync(EmployeeModel employee);
        Task UpdateAsync(EmployeeModel employee);
        Task DeleteAsync(string employeeId);
        Task<EmployeeModel> GetbyIdAsync(string employeeId);
        Task<List<EmployeeModel>> ListbyFilterAsync(string employeeId, string name);
    }
}

using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        public Task CreateAsync(EmployeeModel employee);
        public Task UpdateAsync(EmployeeModel employee);
        public Task DeleteAsync(string employeeId);
        public Task<bool> ExistsbyIdAsync(string employeeId);
        public Task<bool> ExistsbyLoginAsync(string employeeLogin);
        public Task<EmployeeModel> GetbyIdAsync(string employeeId);
        public Task<List<EmployeeModel>> ListbyFilterAsync(string employeeId, string name);
    }
}

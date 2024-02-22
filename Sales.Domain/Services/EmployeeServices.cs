using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        public Task<bool> AuthAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetbyIdAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeModel>> ListbyFilterAsync(string employeeId, string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}

using Sales.Application.DataContract.Request.Employee;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Interfaces
{
    public interface IEmployeeApplication
    {
        public Task<Response> CreateAsync(CreateEmployeeRequest employee);
    }
}

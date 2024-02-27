using Sales.Application.DataContract.Request.Client;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Interfaces
{
    public interface IClientApplication
    {
        public Task<Response> CreateAsync(CreateClientRequest client);
    }
}

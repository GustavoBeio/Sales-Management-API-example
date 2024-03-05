using Sales.Application.DataContract.Request.Client;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(CreateClientRequest createClientRequest);
        Task<Response> UpdateAsync(UpdateClientRequest updateClientRequest);
        Task<Response<ClientModel>> GetbyIdAsync(string clientId);
        Task<Response<List<ClientModel>>> ListbyFilterAsync( string clientId, string name);
        Task<Response> DeleteAsync(string clientId);
    }
}

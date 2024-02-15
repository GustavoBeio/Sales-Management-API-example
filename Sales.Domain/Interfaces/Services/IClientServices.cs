using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IClientServices
    {
        Task<Response> CreateAsync(ClientModel client);
        Task<Response> UpdadteAsync(ClientModel client);
        Task<Response<ClientModel>> GetbyIdAsync(string clientId);
        Task<Response<List<ClientModel>>> ListbyFilterAsync(string clientId, string name);
        Task<Response> DeleteAsync(string clientId);
    }
}

using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IClientServices
    {
        public Task<Response> CreateAsync(ClientModel client);
        public Task<Response> UpdadteAsync(ClientModel client);
        public Task<Response<ClientModel>> GetbyIdAsync(string clientId);
        public Task<Response<List<ClientModel>>> ListbyFilterAsync(string clientId, string name);
        public Task<Response> DeleteAsync(string clientId);
    }
}

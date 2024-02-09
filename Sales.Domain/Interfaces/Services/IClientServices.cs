using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Services
{
    public interface IClientServices
    {
        Task CreateAsync(ClientModel client);
        Task UpdadteAsync(ClientModel client);
        Task<ClientModel> GetbyIdAsync(string clientId);
        Task<List<ClientModel>> ListbyFilterAsync(string clientId, string name);
        Task DeleteAsync(string clientId);
    }
}

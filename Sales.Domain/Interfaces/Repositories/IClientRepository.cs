using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(string clientId);
        Task<ClientModel> GetbyIdAsync(string clientId);
        Task<List<ClientModel>> ListbyFilterAsync(string clientId, string name);
        

    }
}

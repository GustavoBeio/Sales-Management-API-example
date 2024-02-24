using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        public Task CreateAsync(ClientModel client);
        public Task UpdateAsync(ClientModel client);
        public Task DeleteAsync(string clientId);
        public Task<bool> ExistsbyIdAsync(string clientId);
        public Task<bool> ExistsbyNameAsync(string clientName);
        public Task<ClientModel> GetbyIdAsync(string clientId);
        public Task<List<ClientModel>> ListbyFilterAsync(string clientId, string name);
        

    }
}

using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        public Task CreateAsync(ProductModel product);
        public Task UpdateAsync(ProductModel product);
        public Task DeleteAsync(string productId);
        public Task<bool> ExistsbyIdAsync(string productId);
        public Task<ProductModel> GetbyIdAsync(string productId);
        public Task<List<ProductModel>> ListbyFilterAsync(string productId, string clientId);
    }
}

using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(string productId);
        Task<bool> ExistsAsync(string productId);
        Task<ProductModel> GetbyIdAsync(string productId);
        Task<List<ProductModel>> ListbyFilterAsync(string productId, string clientId);
    }
}

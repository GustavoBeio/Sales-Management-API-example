using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IProductServices
    {
        Task<Response> CreateAsync(ProductModel product);
        Task<Response> UpdateAsync(ProductModel product);
        Task<Response> DeleteAsync(string productId);
        Task<Response<ProductModel>> GetbyIdAsync(string productId);
        Task<Response<List<ProductModel>>> ListbyFilterAsync(string productId, string clientId);
    }
}

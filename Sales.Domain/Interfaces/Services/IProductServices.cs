using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IProductServices
    {
        public Task<Response> CreateAsync(ProductModel product);
        public Task<Response> UpdateAsync(ProductModel product);
        public Task<Response> DeleteAsync(string productId);
        public Task<Response<ProductModel>> GetbyIdAsync(string productId);
        public Task<Response<List<ProductModel>>> ListbyFilterAsync(string productId, string clientId);
    }
}

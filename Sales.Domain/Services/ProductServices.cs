using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Services
{
    public class ProductServices : IProductServices
    {
        public Task<Response> CreateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductModel>> GetbyIdAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductModel>>> ListbyFilterAsync(string productId, string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}

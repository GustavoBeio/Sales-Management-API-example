using Sales.Application.DataContract.Request.Product;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Interfaces
{
    public interface IProductApplication
    {
        Task<Response> CreateAsync(CreateProductRequest createProductRequest);
        Task<Response> UpdateAsync(UpdateProductRequest updateProductRequest);
        Task<Response> DeleteAsync(string productId);
        Task<Response<ProductModel>> GetbyIdAsync(string productId);
        Task<Response<List<ProductModel>>> ListbyFilterAsync(string productId, string clientId);
    }
}

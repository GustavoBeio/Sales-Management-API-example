using Sales.Application.DataContract.Request;
using Sales.Application.DataContract.Request.ProductOrder;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Interfaces
{
    public interface IProductOrderApplication
    {
        Task<Response> CreateAsync(CreateProductOrderRequest createProductOrderRequest);
        Task<Response> UpdateAsync(UpdateProductOrderRequest updateProductOrderRequest);
        Task<Response> DeleteAsync(string productOrderId);
        Task<Response<ProductOrderModel>> GetbyIdAsync(string productOrderId);
        Task<Response<List<ProductOrderModel>>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId);
    }
}

using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IProductOrderServices
    {
        Task<Response> CreateAsync(ProductOrderModel productOrder);
        Task<Response> UpdadteAsync(ProductOrderModel productOrder);
        Task<Response<ProductOrderModel>> GetbyIdAsync(string productOrderId);
        Task<Response<List<ProductOrderModel>>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId);
        Task<Response> DeleteAsync(string productOrderId);
    }
}

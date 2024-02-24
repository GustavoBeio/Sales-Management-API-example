using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Interfaces.Services
{
    public interface IProductOrderServices
    {
        public Task<Response> CreateAsync(ProductOrderModel productOrder);
        public Task<Response> UpdadteAsync(ProductOrderModel productOrder);
        public Task<Response<ProductOrderModel>> GetbyIdAsync(string productOrderId);
        public Task<Response<List<ProductOrderModel>>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId);
        public Task<Response> DeleteAsync(string productOrderId);
    }
}

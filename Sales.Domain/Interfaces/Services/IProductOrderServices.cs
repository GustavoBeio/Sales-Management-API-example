using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Services
{
    public interface IProductOrderServices
    {
        Task CreateAsync(ProductOrderModel productOrder);
        Task UpdadteAsync(ProductOrderModel productOrder);
        Task<ProductOrderModel> GetbyIdAsync(string productOrderId);
        Task<List<ProductOrderModel>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId);
        Task DeleteAsync(string productOrderId);
    }
}

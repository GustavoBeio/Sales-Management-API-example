using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IProductOrderRepository
    {
        Task CreateAsync(ProductOrderModel productOrder);
        Task CreateItemAsync(ProductOrderItemModel productOrderItem);
        Task UpdateAsync(ProductOrderModel productOrder);
        Task UpdateItemAsync(ProductOrderItemModel productOrderItem);
        Task DeleteAsync(string productOrderId);
        Task DeleteItemAsync(string productOrderItemId);
        Task<ProductOrderModel> GetbyIdAsync(string productOrderId);
        Task<List<ProductOrderModel>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId);
        Task<List<ProductOrderItemModel>> ListbyFilterItemAsync(string productOrderId, string clientId, string employeeId);
    }
}

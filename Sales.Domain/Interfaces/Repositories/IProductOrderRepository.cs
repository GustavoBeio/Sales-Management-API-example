using Sales.Domain.Models;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IProductOrderRepository
    {
        public Task CreateAsync(ProductOrderModel productOrder);
        public Task CreateItemAsync(ProductOrderItemModel productOrderItem);
        public Task UpdateAsync(ProductOrderModel productOrder);
        public Task UpdateItemAsync(ProductOrderItemModel productOrderItem);
        public Task DeleteAsync(string productOrderId);
        public Task<bool> ExistsAsync(string productOrderId);
        public Task DeleteItemAsync(string productOrderItemId);
        public Task<ProductOrderModel> GetbyIdAsync(string productOrderId);
        public Task<List<ProductOrderModel>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId);
        public Task<List<ProductOrderItemModel>> ListItembyOrderIdAsync(string productOrderId);
    }
}

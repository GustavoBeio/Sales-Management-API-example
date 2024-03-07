using Sales.Domain.Models;

namespace Sales.Application.DataContract.Response
{
    public class ProductOrderResponse
    {
        public string Id { get; set; } = string.Empty;
        public ClientModel Client { get; set; } = new();
        public EmployeeModel Employee { get; set; } = new();
        public List<ProductOrderItemModel> ProductOrderItems { get; set; } = [];
    }
}

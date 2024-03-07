using Sales.Domain.Models;

namespace Sales.Application.DataContract.Request
{
    public class CreateProductOrderRequest
    {
        public ClientModel Client { get; set; } = new();
        public EmployeeModel Employee { get; set; } = new();
        public List<ProductOrderItemModel> ProductOrderItems { get; set; } = [];
    }
}

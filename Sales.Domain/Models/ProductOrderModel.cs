﻿namespace Sales.Domain.Models
{
    public class ProductOrderModel : EntityBase
    {
        public ClientModel Client { get; set; } = new();
        public EmployeeModel Employee { get; set; } = new();
        public List<ProductOrderItemModel> ProductOrderItems { get; set; } = [];
    }
}

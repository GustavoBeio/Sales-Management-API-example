﻿namespace Sales.Domain.Models
{
    public class ProductModel : EntityBase
    {
        public string Description { get; set; } = string.Empty;
        public decimal Sellvalue { get; set; }
        public int Stock { get; set; }
    }
}

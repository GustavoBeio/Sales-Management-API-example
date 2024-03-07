namespace Sales.Application.DataContract.Request.Product
{
    public class CreateProductRequest
    {
        public string Description { get; set; } = string.Empty;
        public decimal Sellvalue { get; set; }
        public int Stock { get; set; }
    }
}

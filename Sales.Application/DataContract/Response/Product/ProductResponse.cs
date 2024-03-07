namespace Sales.Application.DataContract.Response
{
    public class ProductResponse
    {
        public string Id { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Sellvalue { get; set; }
        public int Stock { get; set; }
    }
}

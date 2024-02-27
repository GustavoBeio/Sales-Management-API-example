
namespace Sales.Application.DataContract.Request.Client
{
    public sealed class CreateClientRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
    }
}

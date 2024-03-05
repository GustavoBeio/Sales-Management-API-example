
namespace Sales.Application.DataContract.Request.Employee
{
    public class CreateEmployeeRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Passwordhash { get; set; } = string.Empty;
    }
}

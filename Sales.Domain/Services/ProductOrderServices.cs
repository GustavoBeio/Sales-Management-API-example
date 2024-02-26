using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Services
{
    public class ProductOrderServices(IProductOrderRepository productOrderRepository) : IProductOrderServices
    {
        private readonly IProductOrderRepository _productOrderRepository = productOrderRepository;
        async Task<Response> IProductOrderServices.CreateAsync(ProductOrderModel productOrder)
        {
            Response response = new();
            ProductOrderValidation validation = new();
            var errors = validation.Validate(productOrder).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            await _productOrderRepository.CreateAsync(productOrder);
            return response;
        }
        Task<Response> IProductOrderServices.DeleteAsync(string productOrderId)
        {
            Response response = new();

            if (!await _employeeRepository.ExistsbyIdAsync(employeeId))
            {
                response.Report.Add(Report.Create($"employee {employeeId} does not exists."));
                return response;
            }
            await _employeeRepository.DeleteAsync(employeeId);
            return response; ;
        }

        Task<Response<ProductOrderModel>> IProductOrderServices.GetbyIdAsync(string productOrderId)
        {
            throw new NotImplementedException();
        }

        Task<Response<List<ProductOrderModel>>> IProductOrderServices.ListbyFilterAsync(string productOrderId, string clientId, string employeeId)
        {
            throw new NotImplementedException();
        }

        async Task<Response> IProductOrderServices.UpdadteAsync(ProductOrderModel productOrder)
        {
            Response response = new();
            ProductOrderValidation validation = new();
            var errors = validation.Validate(productOrder).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            if (!await _productOrderRepository.ExistsbyIdAsync(productOrder.Id))
            {
                response.Report.Add(Report.Create($"Client {client.Id} does not exists."));
                return response;
            }
            await _productOrderRepository.CreateAsync(productOrder);
            return response;
        }
    }
}

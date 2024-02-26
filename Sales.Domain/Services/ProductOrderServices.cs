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
        async Task<Response> IProductOrderServices.DeleteAsync(string productOrderId)
        {
            Response response = new();

            if (!await _productOrderRepository.ExistsbyIdAsync(productOrderId))
            {
                response.Report.Add(Report.Create($"employee {productOrderId} does not exists."));
                return response;
            }
            await _productOrderRepository.DeleteAsync(productOrderId);
            return response; ;
        }

        async Task<Response<ProductOrderModel>> IProductOrderServices.GetbyIdAsync(string productOrderId)
        {
            Response<ProductOrderModel> response = new();
            if(!await _productOrderRepository.ExistsbyIdAsync(productOrderId))
            {
                response.Report.Add(Report.Create($"Order {productOrderId} does not exists."));
                return response;
            }
            var data = await _productOrderRepository.GetbyIdAsync(productOrderId);
            data.ProductOrderItems = await _productOrderRepository.ListItembyOrderIdAsync(productOrderId);
            response.Data = data;
            return response;
        }

        async Task<Response<List<ProductOrderModel>>> IProductOrderServices.ListbyFilterAsync(string productOrderId, string clientId, string employeeId)
        {
            Response<List<ProductOrderModel>> response = new();
            if (!string.IsNullOrWhiteSpace(productOrderId))
            {
                if (!await _productOrderRepository.ExistsbyIdAsync(productOrderId))
                {
                    response.Report.Add(Report.Create($"employee {productOrderId} does not exists."));
                    return response;
                }
            }
            await _productOrderRepository.DeleteAsync(productOrderId);
            return response; ;
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
                response.Report.Add(Report.Create($"Client {productOrder.Id} does not exists."));
                return response;
            }
            await _productOrderRepository.CreateAsync(productOrder);
            return response;
        }
    }
}

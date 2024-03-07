using AutoMapper;
using Sales.Application.DataContract.Request;
using Sales.Application.DataContract.Request.ProductOrder;
using Sales.Application.Interfaces;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Applications
{
    public class ProductOrderApplication(IProductOrderServices productOrderService, IMapper mapper) : IProductOrderApplication
    {
        private readonly IProductOrderServices _productOrderService = productOrderService;
        private readonly IMapper _mapper = mapper;
        async Task<Response> IProductOrderApplication.CreateAsync(CreateProductOrderRequest createProductOrderRequest)
        {
            return await _productOrderService.CreateAsync(_mapper.Map<ProductOrderModel>(createProductOrderRequest));
        }

        async Task<Response> IProductOrderApplication.DeleteAsync(string productOrderId)
        {
            return await _productOrderService.DeleteAsync(productOrderId);
        }

        async Task<Response<ProductOrderModel>> IProductOrderApplication.GetbyIdAsync(string productOrderId)
        {
            return await _productOrderService.GetbyIdAsync(productOrderId);
        }

        async Task<Response<List<ProductOrderModel>>> IProductOrderApplication.ListbyFilterAsync(string productOrderId, string clientId, string employeeId)
        {
            return await _productOrderService.ListbyFilterAsync(productOrderId, clientId, employeeId);
        }

        async Task<Response> IProductOrderApplication.UpdateAsync(UpdateProductOrderRequest updateProductOrderRequest)
        {
            return await _productOrderService.UpdadteAsync(_mapper.Map<ProductOrderModel>(updateProductOrderRequest));
        }
    }
}

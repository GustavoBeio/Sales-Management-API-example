using AutoMapper;
using Sales.Application.DataContract.Request.Product;
using Sales.Application.Interfaces;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;

namespace Sales.Application.Applications
{
    public class ProductApplication(IProductServices productService, IMapper mapper) : IProductApplication
    {
        private readonly IProductServices _productService = productService;
        private readonly IMapper _mapper = mapper;
        async Task<Response> IProductApplication.CreateAsync(CreateProductRequest createProductRequest)
        {
            return await _productService.CreateAsync(_mapper.Map<ProductModel>(createProductRequest));
        }

        async Task<Response> IProductApplication.DeleteAsync(string productId)
        {
            return await _productService.DeleteAsync(productId);
        }

        async Task<Response<ProductModel>> IProductApplication.GetbyIdAsync(string productId)
        {
            return await _productService.GetbyIdAsync(productId);
        }

        async Task<Response<List<ProductModel>>> IProductApplication.ListbyFilterAsync(string productId, string clientId)
        {
            return await _productService.ListbyFilterAsync(productId, clientId);
        }

        async Task<Response> IProductApplication.UpdateAsync(UpdateProductRequest updateProductRequest)
        {
            return await _productService.UpdateAsync(_mapper.Map<ProductModel>(updateProductRequest));
        }
    }
}

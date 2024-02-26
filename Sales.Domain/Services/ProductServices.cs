using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Services
{
    public class ProductServices(IProductRepository productRepository) : IProductServices
    {
        private readonly IProductRepository _productRepository = productRepository;
        async Task<Response> IProductServices.CreateAsync(ProductModel product)
        {
            Response response = new();
            ProductValidation validation = new();
            var errors = validation.Validate(product).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            await _productRepository.CreateAsync(product);
            return response;
        }

        async Task<Response> IProductServices.DeleteAsync(string productId)
        {
            Response response = new();

            if (!await _productRepository.ExistsbyIdAsync(productId))
            {
                response.Report.Add(Report.Create($"Product {productId} does not exists."));
                return response;
            }
            await _productRepository.DeleteAsync(productId);
            return response;
        }

         async Task<Response<ProductModel>> IProductServices.GetbyIdAsync(string productId)
        {
            Response<ProductModel> response = new();

            if (!await _productRepository.ExistsbyIdAsync(productId))
            {
                response.Report.Add(Report.Create($"Product {productId} does not exists."));
                return response;
            }
            await _productRepository.GetbyIdAsync(productId);
            return response;
        }

        async Task<Response<List<ProductModel>>> IProductServices.ListbyFilterAsync(string productId, string description)
        {
            Response<List<ProductModel>> response = new();
            if (!string.IsNullOrWhiteSpace(productId))
            {
                if (!await _productRepository.ExistsbyIdAsync(productId))
                {
                    response.Report.Add(Report.Create($"Product `{productId} does not exists"));
                    return response;
                }
            }
            response.Data = await _productRepository.ListbyFilterAsync(productId, description);
            return response;
        }

        async Task<Response> IProductServices.UpdateAsync(ProductModel product)
        {
            Response response = new();
            ProductValidation validation = new();
            var errors = validation.Validate(product).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            if (!await _productRepository.ExistsbyIdAsync(product.Id))
            {
                response.Report.Add(Report.Create($"product {product.Id} does not exists."));
                return response;
            }
            await _productRepository.UpdateAsync(product);
            return response;
        }
    }
}

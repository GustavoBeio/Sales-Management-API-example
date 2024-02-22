using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class ProductServices : IProductServices
    {
        public Task CreateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetbyIdAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> ListbyFilterAsync(string productId, string clientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}

using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class ClientServices : IClientServices
    {
        public Task CreateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetbyIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> ListbyFilterAsync(string clientId, string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdadteAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}

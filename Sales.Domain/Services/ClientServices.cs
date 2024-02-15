using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;

        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        Task<Response> IClientServices.CreateAsync(ClientModel client)
        {
            var validation = new ClientValidation();
            var result = validation.Validate(client);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {

                }
            }
            throw new NotImplementedException();
        }
        public Task<Response> DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ClientModel>> GetbyIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ClientModel>>> ListbyFilterAsync(string clientId, string name)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdadteAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}

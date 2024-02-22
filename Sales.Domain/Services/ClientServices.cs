using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;

        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        async Task<Response> IClientServices.CreateAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0) 
                return errors;

            await _clientRepository.CreateAsync(client);
            return response;
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

        async Task<Response> IClientServices.UpdadteAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _clientRepository.CreateAsync(client);
            return response;
        }
    }
}

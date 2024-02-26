using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations;
using Sales.Domain.Validations.Base;

namespace Sales.Domain.Services
{
    public class ClientServices(IClientRepository clientRepository) : IClientServices
    {
        private readonly IClientRepository _clientRepository = clientRepository;

        async Task<Response> IClientServices.CreateAsync(ClientModel client)
        {
            Response response = new();
            ClientValidation validation = new();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            await _clientRepository.CreateAsync(client);
            return response;
        }
        async Task<Response> IClientServices.DeleteAsync(string clientId)
        {
            Response response = new();

            if (!await _clientRepository.ExistsbyIdAsync(clientId))
            {
                response.Report.Add(Report.Create($"Client {clientId} does not exists."));
                return response;
            }
            await _clientRepository.DeleteAsync(clientId);
            return response;
        }

        async Task<Response<ClientModel>> IClientServices.GetbyIdAsync(string clientId)
        {
            Response<ClientModel> response = new();

            if (!await _clientRepository.ExistsbyIdAsync(clientId))
            {
                response.Report.Add(Report.Create($"Client {clientId} does not exists."));
                return response;
            }
            response.Data = await _clientRepository.GetbyIdAsync(clientId);
            return response;
        }

        async Task<Response<List<ClientModel>>> IClientServices.ListbyFilterAsync(string clientId, string name)
        {
            Response<List<ClientModel>> response = new();
            if (!string.IsNullOrWhiteSpace(clientId))
            {
                if (!await _clientRepository.ExistsbyIdAsync(clientId))
                {
                    response.Report.Add(Report.Create($"Client `{clientId} does not exists"));
                    return response;
                }
            }
            response.Data = await _clientRepository.ListbyFilterAsync(clientId, name);
            return response;
        }

        async Task<Response> IClientServices.UpdadteAsync(ClientModel client)
        {
            Response response = new();
            ClientValidation validation = new();
            Response errors = validation.Validate(client).GetErrors();
            if (errors.Report.Count > 0)
            {
                return errors;
            }

            if (!await _clientRepository.ExistsbyIdAsync(client.Id))
            {
                response.Report.Add(Report.Create($"Client {client.Id} does not exists."));
                return response;
            }
            await _clientRepository.UpdateAsync(client);
            return response;
        }
    }
}

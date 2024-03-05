using Sales.Application.DataContract.Request.Client;
using Sales.Application.Interfaces;
using Sales.Domain.Validations.Base;
using Sales.Domain.Interfaces.Services;
using AutoMapper;
using Sales.Domain.Models;

namespace Sales.Application.Applications
{
    public class ClientApplication(IClientServices clientService, IMapper mapper) : IClientApplication
    {
        private readonly IClientServices _clientService = clientService;
        private readonly IMapper _mapper = mapper;

        async Task<Response> IClientApplication.CreateAsync(CreateClientRequest createClientRequest)
        {
            return await _clientService.CreateAsync(_mapper.Map<ClientModel>(createClientRequest));
        }

        async Task<Response> IClientApplication.DeleteAsync(string clientId)
        {
            return await _clientService.DeleteAsync(clientId);
        }

        async Task<Response<ClientModel>> IClientApplication.GetbyIdAsync(string clientId)
        {
            return await _clientService.GetbyIdAsync(clientId);
        }

        async Task<Response<List<ClientModel>>> IClientApplication.ListbyFilterAsync(string clientId, string clientName)
        {
            return await _clientService.ListbyFilterAsync(clientId, clientName);
        }

        async Task<Response> IClientApplication.UpdateAsync(UpdateClientRequest updateClientRequest)
        {
            return await _clientService.UpdadteAsync(_mapper.Map<ClientModel>(updateClientRequest));
        }
    }
}

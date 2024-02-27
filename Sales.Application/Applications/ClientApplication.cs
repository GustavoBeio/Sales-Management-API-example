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

        async Task<Response> IClientApplication.CreateAsync(CreateClientRequest client)
        {
            return await _clientService.CreateAsync(_mapper.Map<ClientModel>(client));
        }
    }
}

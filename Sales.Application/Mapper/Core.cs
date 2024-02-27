using AutoMapper;
using Sales.Application.DataContract.Request.Client;
using Sales.Application.DataContract.Response.Client;
using Sales.Domain.Models;

namespace Sales.Application.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            ClientMap();
        }
        private void ClientMap()
        {
            _ = CreateMap<CreateClientRequest, ClientModel>();
            _ = CreateMap<ClientModel, ClientResponse>();
        }
    }
}

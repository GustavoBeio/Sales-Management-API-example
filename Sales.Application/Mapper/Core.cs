﻿using AutoMapper;
using Sales.Application.DataContract.Request.Client;
using Sales.Application.DataContract.Request.Employee;
using Sales.Application.DataContract.Response.Client;
using Sales.Application.DataContract.Response.Employee;
using Sales.Domain.Models;

namespace Sales.Application.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            ClientMap();
            EmployeeMap();
        }
        private void ClientMap()
        {
            _ = CreateMap<CreateClientRequest, ClientModel>();
            _ = CreateMap<UpdateClientRequest, ClientModel>();
            _ = CreateMap<GetbyIdClientRequest, ClientModel>();
            _ = CreateMap<ListbyFilterClientRequest, ClientModel>();
            _ = CreateMap<DeleteClientRequest, ClientModel>();
            _ = CreateMap<ClientModel, ClientResponse>();
        }
        private void EmployeeMap()
        {
            _ = CreateMap<CreateEmployeeRequest, EmployeeModel>();
            _ = CreateMap<EmployeeModel, EmployeeResponse>();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Validations.Base
{
    public class Response
    {
        public Response()
        {
            Report = []; //Cria uma instancia vazia de List<Report>
        }
        public Response(List<Report> reports)
        {
            Report = reports;
        }
        public Response(Report report) : this([report]) { } //Envia um objeto report unico para o construtor acima que cria uma lista com um valor apenas
        public List<Report> Report { get;}
        public static Response<T> OK<T>(T data) => new(data);
        public static Response OK() => new Response();
        public static Response Unprocessable(List<Report> reports) => new Response(reports);
        public static Response Unprocessable(Report report) => new Response(report);
    }

    public class Response<T> : Response
    {
        public Response()
        {

        }

        public Response(T data)
        {
            Data = data;
        }

        public Response(T data, List<Report> reports) : base(reports)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}

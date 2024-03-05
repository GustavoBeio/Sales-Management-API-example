using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sales.Application.DataContract.Request.Client;
using Sales.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sales_Management_API.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController(IClientApplication clientApplication) : ControllerBase
    {
        private readonly IClientApplication _clientApplication = clientApplication;

        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ["value1", "value2"];
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateClientRequest clientRequest)
        {
           var response = await _clientApplication.CreateAsync(clientRequest);
            return response.Report.Count != 0 ? UnprocessableEntity(response.Report) : Ok(response);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

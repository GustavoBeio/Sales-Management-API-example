using Microsoft.AspNetCore.Mvc;
using Sales.Application.DataContract.Request.Employee;
using Sales.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sales_Management_API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController(IEmployeeApplication employeeApplication) : ControllerBase
    {
        private readonly IEmployeeApplication _employeeApplication = employeeApplication;
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ["value1", "value2"];
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateEmployeeRequest employeeRequest)
        {
            var response = await _employeeApplication.CreateAsync(employeeRequest);
            return response.Report.Count != 0 ? UnprocessableEntity(response.Report) : Ok(response);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using CompuTrabajo.Test.Entities;
using CompuTrabajo.Test.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace CompuTrabajo.Test.Api.Controllers
{
    public class RedarborController : ApiController
    {
        public readonly IEmployeesService _service;
        public RedarborController(IEmployeesService service) 
        {
            _service = service;
        }

        [HttpPost]
        public IHttpActionResult Post(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            _service.create(employee);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<Employee> employees = _service.read();

            if (employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            Employee employees = _service.read(id);

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpPut]
        public IHttpActionResult Put(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            _service.update(employee);

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(int id)
        {
            _service.update(id);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _service.delete(id);

            return Ok();
        }
    }
}

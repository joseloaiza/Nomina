namespace Nomina.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http.Cors;
    using System.Web.Http.Description;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Nomina.Core.DomainEntities;
    using Nomina.ServicesInterfaces;
    

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET: api/Employee
        [HttpGet]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public ActionResult Get()
        {
            return Ok(this.employeeService.GetAll());
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var empleoye = await employeeService.GetByIdAsync(id);
            return Ok(empleoye);
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await employeeService.CreateAsync(employee);
            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }
            try
            {
                await employeeService.UpdateAsync(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName ==
                              "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }

            try
            {
                Employee empleoye = new Employee() { Id = id };
                await employeeService.DeleteAsync(empleoye);
                return Ok();

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}

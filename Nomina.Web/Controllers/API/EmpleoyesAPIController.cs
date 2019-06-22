

namespace Nomina.Web.Controllers.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http.Cors;
    using System.Web.Http.Description;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Nomina.Web.Data;
    //using Nomina.Web.Data.Entities;
    using Nomina.Core.DomainEntities;
    using Nomina.ServicesInterfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class EmpleoyesAPIController : ControllerBase
    {
        //private readonly IEmpleoyeRepository empleoyeRepository;
        private readonly IEmployeeService employeeService;

        //public EmpleoyesAPIController(IEmpleoyeRepository empleoyeRepository)
        //{
        //    this.empleoyeRepository = empleoyeRepository;
        //}

        public EmpleoyesAPIController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET: api/EmpleoyesAPI
        [HttpGet]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public ActionResult GetEmpleoyes()
        {
            return Ok(this.employeeService.GetAll());
        }



        // GET: api/EmpleoyesAPI/5
        [HttpGet("{id}")]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public async Task<IActionResult> GetEmpleoye([FromRoute] int id)
        {
            var empleoye = await employeeService.GetByIdAsync(id);
            return Ok(empleoye);
        }

        // POST: api/EmpleoyesAPI
        [HttpPost]
        [ResponseType(typeof(Employees))]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public async Task<IActionResult> PostEmployee([FromBody] Employees employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await employeeService.CreateAsync(employee);
            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, [FromBody] Employees employee)
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
                Employees empleoye = new Employees() { Id = id };
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
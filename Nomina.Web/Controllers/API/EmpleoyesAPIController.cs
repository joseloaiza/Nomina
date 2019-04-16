

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
    using Nomina.Web.Data.Entities;

    [Route("api/[controller]")]
    [ApiController]
    public class EmpleoyesAPIController : ControllerBase
    {
        private readonly IEmpleoyeRepository empleoyeRepository;

        public EmpleoyesAPIController(IEmpleoyeRepository empleoyeRepository)
        {
            this.empleoyeRepository = empleoyeRepository;
        }

        // GET: api/EmpleoyesAPI
        [HttpGet]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]      
        [Route("AllEmployeeDetails")]
        public ActionResult GetEmpleoyes()
        {
            return Ok(this.empleoyeRepository.GetAll());
        }

        // GET: api/Empleoyes/5
        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetEmpleoye([FromRoute] int id)
        {
           var empleoye = await empleoyeRepository.GetByIdAsync(id);
           return Ok(empleoye);
        }

        // POST: api/Employees

        [HttpPost]
        [ResponseType(typeof(Employee)) ]
        public async Task<IActionResult> PostEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await empleoyeRepository.CreateAsync(employee);
            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }


    }
}
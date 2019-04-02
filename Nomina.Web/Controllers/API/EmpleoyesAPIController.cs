

namespace Nomina.Web.Controllers.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Nomina.Web.Data;

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
        public ActionResult GetEmpleoyes()
        {
            return Ok(this.empleoyeRepository.GetAll());
        }

        // GET: api/Empleoyes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpleoye([FromRoute] string id)
        {
           var empleoye = await empleoyeRepository.GetByIdAsync(Int32.Parse(id));
           return Ok(empleoye);
        }

    }
}
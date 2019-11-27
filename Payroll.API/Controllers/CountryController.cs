namespace Payroll.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http.Cors;
    using System.Web.Http.Description;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Payroll.Models.Entities;
    
    using Payroll.Domain.Interfaces;

    //using Nomina.Core.DomainEntities;
    //using Nomina.ServicesInterfaces;
    
    //cambio jose
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        // GET: api/Employee
        [HttpGet]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public ActionResult Get()
        {
            var response = countryService.Get();
            return Ok(response.Result);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        [EnableCors("AllowOrigin", headers: "*", methods: "*")]
        public ActionResult Get([FromRoute] Guid id)
        {
            var response = countryService.Get(id);
            return Ok(response);
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await countryService.Create(country);
            return CreatedAtAction("GetEmployee", new { id = country.Id }, country);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Country country)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != country.Id)
                {
                    return BadRequest();
                }

                await countryService.Update(country);
                return Ok();
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
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
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }

                await countryService.Delete(id);
                return Ok();

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}

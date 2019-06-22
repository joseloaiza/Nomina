using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nomina.Web.Data;
using Nomina.Core.DomainEntities;

namespace Nomina.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleoyesController : ControllerBase
    {
        private readonly DataContext _context;

        public EmpleoyesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Empleoyes
        [HttpGet]
        public IEnumerable<Employees> GetEmpleoyes()
        {
            return _context.Employees;
        }

        // GET: api/Empleoyes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpleoye([FromRoute] string id)
        {
           
            var empleoye = await _context.Employees.FindAsync(id);

            if (empleoye == null)
            {
                return NotFound();
            }

            return Ok(empleoye);
        }

        // PUT: api/Empleoyes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleoye([FromRoute] int id, [FromBody] Employees employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleoyeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Empleoyes
        [HttpPost]
        public async Task<IActionResult> PostEmpleoye([FromBody] Employees employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleoye", new { id = employee.Id }, employee);
        }

        // DELETE: api/Empleoyes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleoye([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var empleoye = await _context.Employees.FindAsync(id);
            if (empleoye == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(empleoye);
            await _context.SaveChangesAsync();

            return Ok(empleoye);
        }

        private bool EmpleoyeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
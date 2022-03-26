using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShippingLibrary.Models;

namespace _300490950_morden__Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomesticExpressesController : ControllerBase
    {
        private readonly mssqlContext _context;

        public DomesticExpressesController(mssqlContext context)
        {
            _context = context;
        }

        // GET: api/DomesticExpresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomesticExpress>>> GetDomesticExpresses()
        {
            return await _context.DomesticExpresses.ToListAsync();
        }

        // GET: api/DomesticExpresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DomesticExpress>> GetDomesticExpress(int id)
        {
            var domesticExpress = await _context.DomesticExpresses.FindAsync(id);

            if (domesticExpress == null)
            {
                return NotFound();
            }

            return domesticExpress;
        }

        // PUT: api/DomesticExpresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomesticExpress(int id, DomesticExpress domesticExpress)
        {
            if (id != domesticExpress.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(domesticExpress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomesticExpressExists(id))
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

        // POST: api/DomesticExpresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DomesticExpress>> PostDomesticExpress(DomesticExpress domesticExpress)
        {
            _context.DomesticExpresses.Add(domesticExpress);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DomesticExpressExists(domesticExpress.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDomesticExpress", new { id = domesticExpress.ZoneId }, domesticExpress);
        }

        // DELETE: api/DomesticExpresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomesticExpress(int id)
        {
            var domesticExpress = await _context.DomesticExpresses.FindAsync(id);
            if (domesticExpress == null)
            {
                return NotFound();
            }

            _context.DomesticExpresses.Remove(domesticExpress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomesticExpressExists(int id)
        {
            return _context.DomesticExpresses.Any(e => e.ZoneId == id);
        }
    }
}

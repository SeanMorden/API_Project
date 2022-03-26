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
    public class DomesticExpressEarliesController : ControllerBase
    {
        private readonly mssqlContext _context;

        public DomesticExpressEarliesController(mssqlContext context)
        {
            _context = context;
        }

        // GET: api/DomesticExpressEarlies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomesticExpressEarly>>> GetDomesticExpressEarlies()
        {
            return await _context.DomesticExpressEarlies.ToListAsync();
        }

        // GET: api/DomesticExpressEarlies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DomesticExpressEarly>> GetDomesticExpressEarly(int id)
        {
            var domesticExpressEarly = await _context.DomesticExpressEarlies.FindAsync(id);

            if (domesticExpressEarly == null)
            {
                return NotFound();
            }

            return domesticExpressEarly;
        }

        // PUT: api/DomesticExpressEarlies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomesticExpressEarly(int id, DomesticExpressEarly domesticExpressEarly)
        {
            if (id != domesticExpressEarly.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(domesticExpressEarly).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomesticExpressEarlyExists(id))
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

        // POST: api/DomesticExpressEarlies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DomesticExpressEarly>> PostDomesticExpressEarly(DomesticExpressEarly domesticExpressEarly)
        {
            _context.DomesticExpressEarlies.Add(domesticExpressEarly);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DomesticExpressEarlyExists(domesticExpressEarly.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDomesticExpressEarly", new { id = domesticExpressEarly.ZoneId }, domesticExpressEarly);
        }

        // DELETE: api/DomesticExpressEarlies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomesticExpressEarly(int id)
        {
            var domesticExpressEarly = await _context.DomesticExpressEarlies.FindAsync(id);
            if (domesticExpressEarly == null)
            {
                return NotFound();
            }

            _context.DomesticExpressEarlies.Remove(domesticExpressEarly);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomesticExpressEarlyExists(int id)
        {
            return _context.DomesticExpressEarlies.Any(e => e.ZoneId == id);
        }
    }
}

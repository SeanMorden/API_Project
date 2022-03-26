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
    public class DomesticExpressSaversController : ControllerBase
    {
        private readonly mssqlContext _context;

        public DomesticExpressSaversController(mssqlContext context)
        {
            _context = context;
        }

        // GET: api/DomesticExpressSavers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomesticExpressSaver>>> GetDomesticExpressSavers()
        {
            return await _context.DomesticExpressSavers.ToListAsync();
        }

        // GET: api/DomesticExpressSavers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DomesticExpressSaver>> GetDomesticExpressSaver(int id)
        {
            var domesticExpressSaver = await _context.DomesticExpressSavers.FindAsync(id);

            if (domesticExpressSaver == null)
            {
                return NotFound();
            }

            return domesticExpressSaver;
        }

        // PUT: api/DomesticExpressSavers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomesticExpressSaver(int id, DomesticExpressSaver domesticExpressSaver)
        {
            if (id != domesticExpressSaver.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(domesticExpressSaver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomesticExpressSaverExists(id))
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

        // POST: api/DomesticExpressSavers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DomesticExpressSaver>> PostDomesticExpressSaver(DomesticExpressSaver domesticExpressSaver)
        {
            _context.DomesticExpressSavers.Add(domesticExpressSaver);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DomesticExpressSaverExists(domesticExpressSaver.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDomesticExpressSaver", new { id = domesticExpressSaver.ZoneId }, domesticExpressSaver);
        }

        // DELETE: api/DomesticExpressSavers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomesticExpressSaver(int id)
        {
            var domesticExpressSaver = await _context.DomesticExpressSavers.FindAsync(id);
            if (domesticExpressSaver == null)
            {
                return NotFound();
            }

            _context.DomesticExpressSavers.Remove(domesticExpressSaver);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomesticExpressSaverExists(int id)
        {
            return _context.DomesticExpressSavers.Any(e => e.ZoneId == id);
        }
    }
}

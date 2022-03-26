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
    public class DomesticStandardsController : ControllerBase
    {
        private readonly mssqlContext _context;

        public DomesticStandardsController(mssqlContext context)
        {
            _context = context;
        }

        // GET: api/DomesticStandards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomesticStandard>>> GetDomesticStandards()
        {
            return await _context.DomesticStandards.ToListAsync();
        }

        // GET: api/DomesticStandards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DomesticStandard>> GetDomesticStandard(int id)
        {
            var domesticStandard = await _context.DomesticStandards.FindAsync(id);

            if (domesticStandard == null)
            {
                return NotFound();
            }

            return domesticStandard;
        }

        // PUT: api/DomesticStandards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomesticStandard(int id, DomesticStandard domesticStandard)
        {
            if (id != domesticStandard.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(domesticStandard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomesticStandardExists(id))
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

        // POST: api/DomesticStandards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DomesticStandard>> PostDomesticStandard(DomesticStandard domesticStandard)
        {
            _context.DomesticStandards.Add(domesticStandard);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DomesticStandardExists(domesticStandard.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDomesticStandard", new { id = domesticStandard.ZoneId }, domesticStandard);
        }

        // DELETE: api/DomesticStandards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomesticStandard(int id)
        {
            var domesticStandard = await _context.DomesticStandards.FindAsync(id);
            if (domesticStandard == null)
            {
                return NotFound();
            }

            _context.DomesticStandards.Remove(domesticStandard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomesticStandardExists(int id)
        {
            return _context.DomesticStandards.Any(e => e.ZoneId == id);
        }
    }
}

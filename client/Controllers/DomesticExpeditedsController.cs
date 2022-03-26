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
    public class DomesticExpeditedsController : ControllerBase
    {
        private readonly mssqlContext _context;

        public DomesticExpeditedsController(mssqlContext context)
        {
            _context = context;
        }

        // GET: api/DomesticExpediteds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomesticExpedited>>> GetDomesticExpediteds()
        {
            return await _context.DomesticExpediteds.ToListAsync();
        }

        // GET: api/DomesticExpediteds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DomesticExpedited>> GetDomesticExpedited(int id)
        {
            var domesticExpedited = await _context.DomesticExpediteds.FindAsync(id);

            if (domesticExpedited == null)
            {
                return NotFound();
            }

            return domesticExpedited;
        }

        // PUT: api/DomesticExpediteds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomesticExpedited(int id, DomesticExpedited domesticExpedited)
        {
            if (id != domesticExpedited.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(domesticExpedited).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomesticExpeditedExists(id))
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

        // POST: api/DomesticExpediteds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DomesticExpedited>> PostDomesticExpedited(DomesticExpedited domesticExpedited)
        {
            _context.DomesticExpediteds.Add(domesticExpedited);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DomesticExpeditedExists(domesticExpedited.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDomesticExpedited", new { id = domesticExpedited.ZoneId }, domesticExpedited);
        }

        // DELETE: api/DomesticExpediteds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomesticExpedited(int id)
        {
            var domesticExpedited = await _context.DomesticExpediteds.FindAsync(id);
            if (domesticExpedited == null)
            {
                return NotFound();
            }

            _context.DomesticExpediteds.Remove(domesticExpedited);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomesticExpeditedExists(int id)
        {
            return _context.DomesticExpediteds.Any(e => e.ZoneId == id);
        }
    }
}

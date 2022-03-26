using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _300490950_morden__Project.DTOs;
using _300490950_morden__Project.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShippingLibrary.Models;

namespace _300490950_morden__Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceCodesController : ControllerBase
    {
        private IShippingRepository<ProvinceCode,string> _provRepo;
        private readonly IMapper _mapper;

        public ProvinceCodesController(IShippingRepository<ProvinceCode,string> provRepo ,IMapper mapper)
        {
            _provRepo = provRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProvinceCode>> GetAll()
        {
            var provInfos = await _provRepo.GetAll();
            var result = _mapper.Map<IEnumerable<ProvinceCode>>(provInfos);

            return Ok(result);
        }


        //private readonly mssqlContext _context;

        //public ProvinceCodesController(mssqlContext context)
        //{
        //    _context = context;
        //}

        //// GET: api/ProvinceCodes
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ProvinceCode>>> GetProvinceCodes()
        //{
        //    return await _context.ProvinceCodes.ToListAsync();
        //}

        //// GET: api/ProvinceCodes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ProvinceCode>> GetProvinceCode(string id)
        //{
        //    var provinceCode = await _context.ProvinceCodes.FindAsync(id);


        //    if (provinceCode == null)
        //    {
        //        return NotFound();
        //    }

        //    return provinceCode;
        //}

        //// PUT: api/ProvinceCodes/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProvinceCode(string id, ProvinceCode provinceCode)
        //{
        //    if (id != provinceCode.Province)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(provinceCode).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProvinceCodeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/ProvinceCodes
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<ProvinceCode>> PostProvinceCode(ProvinceCode provinceCode)
        //{
        //    _context.ProvinceCodes.Add(provinceCode);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProvinceCodeExists(provinceCode.Province))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetProvinceCode", new { id = provinceCode.Province }, provinceCode);
        //}

        //// DELETE: api/ProvinceCodes/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProvinceCode(string id)
        //{
        //    var provinceCode = await _context.ProvinceCodes.FindAsync(id);
        //    if (provinceCode == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ProvinceCodes.Remove(provinceCode);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ProvinceCodeExists(string id)
        //{
        //    return _context.ProvinceCodes.Any(e => e.Province == id);
        //}
    }
}

using Microsoft.EntityFrameworkCore;
using ShippingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _300490950_morden__Project.Services
{
    public class DomesticStandardRepository : IShippingRepository<DomesticStandard, int>
    {
        private readonly mssqlContext _context;

        public DomesticStandardRepository(mssqlContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var domesticStandard = await _context.DomesticStandards.FindAsync(id);
            _context.DomesticStandards.Remove(domesticStandard);
            _ = Save();
        }

        public async Task<IEnumerable<DomesticStandard>> GetAll()
        {
            return await _context.DomesticStandards.ToListAsync();
             
        }

        public async Task<DomesticStandard> GetById(int id)
        {
            return await _context.DomesticStandards.FindAsync(id);
        }

        public void Insert(DomesticStandard entity)
        {
            _context.DomesticStandards.Add(entity);
            _ = Save();
        }


        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public Task<DomesticStandard> Update(int id, DomesticStandard entity)
        {
            throw new NotImplementedException();
        }
    }
}

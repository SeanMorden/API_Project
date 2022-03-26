using Microsoft.EntityFrameworkCore;
using ShippingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _300490950_morden__Project.Services
{
    public class ProvinceCodeRepository : IShippingRepository<ProvinceCode, string>
    {

        private readonly mssqlContext _context;

        public ProvinceCodeRepository(mssqlContext context)
        {
            _context = context;
        }
        public async Task Delete(string id)
        {
            var provinceCodes = await _context.ProvinceCodes.FindAsync(id);
            _context.ProvinceCodes.Remove(provinceCodes);
            _ = Save();
        }

        public async Task<IEnumerable<ProvinceCode>> GetAll()
        {
            return await _context.ProvinceCodes.ToListAsync();
        }

        public async Task<ProvinceCode> GetById(string id)
        {
            return await _context.ProvinceCodes.FindAsync(id);
        }

        public void Insert(ProvinceCode entity)
        {
            _context.ProvinceCodes.Add(entity);
            try {
                _ = Save();
            }
            catch
            {
                throw;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public Task<ProvinceCode> Update(string id, ProvinceCode entity)
        {
            if (id == entity.Province )
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            try
            {
                _ = Save();
            }
            catch
            {
                throw;
            }

            return null;
            
        }
    }
}

using ShippingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _300490950_morden__Project.Services
{
    public interface IShippingRepository<T1,T2>where T1:class
    {
        
        Task<IEnumerable<T1>> GetAll();
        Task<T1> GetById(T2 id);
        Task<T1> Update(T2 id,T1 entity);
        void Insert(T1 entity);
        Task Delete(T2 id);
        Task Save();

    }
}

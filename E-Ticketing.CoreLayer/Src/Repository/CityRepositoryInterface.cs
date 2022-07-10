using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Repository
{
    public  interface CityRepositoryInterface
    {
        public Task Insert(City city);
        public Task Update(City city);
        public Task<City> GetById(long Id);
        public Task<IEnumerable<City>> GetAll();
    }
}

using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Repository
{
    public interface VehicleRepositoryInterface
    {
        public Task Insert(Vehicle vehicle);
        public Task Update(Vehicle vehicle);
        public Task<Vehicle> GetById(long Id);
        public Task<IEnumerable<Vehicle>> GetAll();
    }
}

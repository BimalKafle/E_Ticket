using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Repository
{
    public interface VehicleSeatRepositoryInterface
    {
        public Task Insert(Vehicle_Seat seat);
        public Task Update(Vehicle_Seat seat);
        public Task<Vehicle_Seat> GetById(long Id);
        public Task<IEnumerable<Vehicle_Seat>> GetAll();
        public Task<IEnumerable<Vehicle_Seat>> GetAvailableSeat();
    }
}

using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Repository
{
    public interface VehicleCategoryRepositoryInterface
    {
        public Task Insert(VehicleCategory category);
        public Task Update(VehicleCategory category);
        public Task<VehicleCategory?> GetById(long Id);
        public Task<IEnumerable<VehicleCategory>> GetAll();
        
    }
}

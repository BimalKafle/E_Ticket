using E_Ticketing.CoreLayer.DTO.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Service.ServiceInterface
{
    public interface VehicleServiceInterface
    {
        public Task Create(VehicleInsertDto dto);
        public Task Update(VehicleUpdateDto dto);

        public Task Activate(long Id);
        public Task Deactivate(long Id);
       
    }
}

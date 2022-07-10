using E_Ticketing.CoreLayer.DTO.VehicleSeat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Service.ServiceInterface
{
    public interface VehicleSeatServiceInterface
    {
        public Task Create(VehicleSeatInsertDto dto);
        public Task Update(VehicleSeatUpdateDto dto);

        public Task BookSeat(long Id);
        public Task CancelSeat(long Id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.VehicleSeat
{
    public class VehicleSeatUpdateDto : VehicleSeatInsertDto
    {
        public long Id { get; protected set; }
        public VehicleSeatUpdateDto(long id,string seatNumber, long vehicleId) : base(seatNumber, vehicleId)
        {
            Id = id;
        }
    }
}

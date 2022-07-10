using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.VehicleSeat
{
    public class VehicleSeatInsertDto
    {
        public VehicleSeatInsertDto(string seatNumber, long vehicleId)
        {
            SeatNumber = seatNumber;
            VehicleId = vehicleId;
        }

        public string SeatNumber { get; protected set; }
        public long VehicleId { get; protected set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.Vehicle
{
    public class VehicleUpdateDto : VehicleInsertDto
    {
        public long VehicleId { get; protected set; }
        public VehicleUpdateDto(long vehicleId,string name, string vehicleNumber, int vehicleCategoryId, int vehicleSeatId) : base(name, vehicleNumber, vehicleCategoryId, vehicleSeatId)
        {
        }
    }
}

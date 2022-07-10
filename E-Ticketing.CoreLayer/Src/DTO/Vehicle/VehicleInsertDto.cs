using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.Vehicle
{
    public class VehicleInsertDto
    {
        public VehicleInsertDto(string name, string vehicleNumber, int vehicleCategoryId, int vehicleSeatId)
        {
            Name = name;
            VehicleNumber = vehicleNumber;
            VehicleCategoryId = vehicleCategoryId;
            VehicleSeatId = vehicleSeatId;
        }

        public string Name { get; protected set; }
        public string VehicleNumber { get; protected set; }
        public int VehicleCategoryId { get; protected set; }
        public int VehicleSeatId { get; protected set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.VehicleCategory
{
    public  class VehicleCategoryInsertDto
    {
        public VehicleCategoryInsertDto(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
    
    }
}

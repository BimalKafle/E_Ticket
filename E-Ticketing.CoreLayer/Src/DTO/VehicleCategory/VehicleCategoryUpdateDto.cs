using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.VehicleCategory
{
    public class VehicleCategoryUpdateDto : VehicleCategoryInsertDto
    {
        public long Id { get; protected set; }
        public VehicleCategoryUpdateDto(long Id,string name) : base(name)
        {
        }
    }
}

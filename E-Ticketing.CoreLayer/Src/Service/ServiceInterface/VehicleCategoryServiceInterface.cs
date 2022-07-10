using E_Ticketing.CoreLayer.DTO.VehicleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Service.ServiceInterface
{
    public interface VehicleCategoryServiceInterface
    {
        public Task Create(VehicleCategoryInsertDto dto);
        public Task Update(VehicleCategoryUpdateDto dto);

        public Task Activate(long Id);
        public Task Deactivate(long Id);
    }
}

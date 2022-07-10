using E_Ticketing.CoreLayer.Entity;
using E_Ticketing.CoreLayer.Repository;
using E_Ticketing.DataLayer.Base;
using E_Ticketing.DataLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.DataLayer.Repository
{
    public class VehicleCategoryRepository : BaseRepository<VehicleCategory>, VehicleCategoryRepositoryInterface
    {

        public VehicleCategoryRepository(ApplicationDbContext context) : base(context)
        {

        }

    
    }
}

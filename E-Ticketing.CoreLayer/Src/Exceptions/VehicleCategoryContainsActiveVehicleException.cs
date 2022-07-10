using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Exceptions
{
    public class VehicleCategoryContainsActiveVehicleException:SystemException
    {
        public VehicleCategoryContainsActiveVehicleException(string message="Cannot Deactivate, Vehicle Category Contain Active Vehicle") : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Exceptions
{
    public class VehicleSeatNotFoundException:SystemException
    {
        public VehicleSeatNotFoundException(string message="Vehicle seat not found") : base(message)
        {

        }
    }
}

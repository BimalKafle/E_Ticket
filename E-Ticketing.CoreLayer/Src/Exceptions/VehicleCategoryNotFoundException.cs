using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Exceptions
{
    public class VehicleCategoryNotFoundException:SystemException
    {
        public VehicleCategoryNotFoundException(string message="Vehicle Category Not Found Exception") : base(message) { }
    }
}

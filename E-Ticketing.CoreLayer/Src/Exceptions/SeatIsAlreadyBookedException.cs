using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Exceptions
{
    public class SeatIsAlreadyBookedException:SystemException
    {
        public SeatIsAlreadyBookedException(string message="Seat is already booked") : base(message)
        {

        }
    }
}

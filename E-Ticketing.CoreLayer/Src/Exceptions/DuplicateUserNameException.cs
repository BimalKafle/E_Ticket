using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Exceptions
{
    public class DuplicateUserNameException:Exception
    {
        public DuplicateUserNameException(string message="User with same name already exist") : base(message)
        {

        }
    }
}

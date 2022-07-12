using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Exceptions
{
    public class UserWithSameEmailAlreadyExistException:Exception
    {
        public UserWithSameEmailAlreadyExistException(string message="User with same email already exist") : base(message)
        {

        }
    }
}

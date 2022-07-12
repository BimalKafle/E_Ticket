using E_Ticketing.CoreLayer.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Service.ServiceInterface
{
    public interface UserServiceInterface
    {
       public Task Create(UserDto dto);
    }
}

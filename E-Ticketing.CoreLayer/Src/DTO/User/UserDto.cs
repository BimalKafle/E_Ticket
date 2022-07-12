using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.User
{
    public class UserDto
    {
        public UserDto(string fullName, string userName, string email, string password)
        {
            FullName = fullName;
            UserName = userName;
            Email = email;
            Password = password;
        }

        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

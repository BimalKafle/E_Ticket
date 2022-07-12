using E_Ticketing.CoreLayer.DTO.User;
using E_Ticketing.CoreLayer.Entity;
using E_Ticketing.CoreLayer.Exceptions;
using E_Ticketing.CoreLayer.Helper;
using E_Ticketing.CoreLayer.Service.ServiceInterface;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace E_Ticketing.CoreLayer.Service
{
    public class UserService : UserServiceInterface
    {
        private readonly UserManager<User> userManager;

        public UserService(UserManager<User> _userManager)
        {
            userManager = _userManager;
        }

        public async Task Create(UserDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            await ValidateUser(dto);
            var user = new User()
            {
                FullName = dto.FullName,
                Email = dto.Email,
                UserName = dto.UserName
            };
            var UserCreation = await userManager.CreateAsync(user, dto.Password).ConfigureAwait(false);
            if (!UserCreation.Succeeded) throw new UserException(UserCreation.Errors.First());
            var createdUser=await userManager.FindByNameAsync(user.UserName).ConfigureAwait(false);
            await userManager.AddToRoleAsync(createdUser.Id, User.RoleUser).ConfigureAwait(false) ;
            scope.Complete();   
        }

        private async Task ValidateUser(UserDto dto)
        {
            var userWithSameEmail = await userManager.FindByEmailAsync(dto.Email).ConfigureAwait(false);
            if (userWithSameEmail != null) throw new UserWithSameEmailAlreadyExistException();
            var userWithSameUserName = await userManager.FindByNameAsync(dto.UserName).ConfigureAwait(false);
            if (userWithSameUserName != null) throw new DuplicateUserNameException();
        }
    }
}

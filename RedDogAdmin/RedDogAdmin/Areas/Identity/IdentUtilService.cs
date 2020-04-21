using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using RedDogAdmin.Models;


namespace RedDogAdmin.Areas.Identity
{
    public class IdentUtilService
    {
        //private readonly UserManager<IdentityUser> UserManager;
        private RedDogUser redDogUser = new RedDogUser();
        public List<RedDogUser> GetUserListAsync(UserManager<IdentityUser> UserManager)
        {
            
            List<RedDogUser> redDogUsers = new List<RedDogUser>();
            IQueryable<IdentityUser> RedUsers = UserManager.Users;
            foreach (var item in RedUsers)
            {
                redDogUsers.Add(new RedDogUser()
                {
                    Id = item.Id,
                    Username =item.UserName,
                    Email = item.Email,
                    EmailConfirmed = item.EmailConfirmed,
                    TwoFactorEnabled=item.TwoFactorEnabled

                });
            }
                return redDogUsers;
        }

        public bool DeleteRedDogUser(String RedDogUserId, UserManager<IdentityUser> UserManager)
        {
            IdentityUser RedUser = null;
            Task<IdentityUser> DeleteUser = UserManager.FindByIdAsync(RedDogUserId);
            UserManager.DeleteAsync(DeleteUser.Result);

            return true;
        }
    }
}

using IndividualUserAccountsAuthentication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndividualUserAccountsAuthentication.App_Start
{
    public class IdentityDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var myinfo = new MyUserInfo() { FirstName = "Jan", LastName = "Kowalski" };
            string roleName = "Admin";
            string password = "P@ssw0rd";

            UserManager.Create(new ApplicationUser() { UserName = "Kazio", UserInfo = myinfo });

            if (!RoleManager.RoleExists(roleName))
            {
                var roleresult = RoleManager.Create(new IdentityRole(roleName));
            }
            var user = new ApplicationUser();
            user.UserName = "Bartek";
            user.UserInfo = myinfo;
            var createResult = UserManager.Create(user, password);

            if (createResult.Succeeded)
            {
                var result = UserManager.AddToRole(user.Id, roleName);
            }
            
            base.Seed(context);
        }
        
    }
}
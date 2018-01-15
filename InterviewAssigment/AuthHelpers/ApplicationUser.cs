using InterviewAssigment.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InterviewAssigment.AuthHelpers
{
    public class ApplicationUser : IdentityUser<string, UserLogin, UserRole, UserClaim> //IdentityUser<int, UserLogin, UserRole, UserClaim>
    {
        private AuthUser _user;
        ///// <summary>
        ///// This will set the identity user details that gets used throughout the system
        ///// </summary>
        public AuthUser AppUser
        {
            get { return _user; }
            set
            {
                _user = value;
                if (_user == null)
                {
                    UserName = null;
                    PasswordHash = null;
                    Id = "";

                }
                else
                {
                    UserName = _user.UserName;
                    PasswordHash = _user.Password;
                    Id = _user.UserId;
                }
            }
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, string> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            //If you added claims to user they will also be added
            foreach (var claim in this.Claims)
            {
                userIdentity.AddClaim(new Claim(claim.ClaimType, claim.ClaimValue));
            }
            //if (this.AppUser.Token != null)
            //	userIdentity.AddClaim(new Claim("Token", this.AppUser.Token));

            // Add custom user claims here
            return userIdentity;
        }
    }

    public class UserRole : IdentityUserRole<string> { }
    public class UserClaim : IdentityUserClaim<string> { }
    public class UserLogin : IdentityUserLogin<string> { }

    public class CustomRole : IdentityRole<string, UserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }
}
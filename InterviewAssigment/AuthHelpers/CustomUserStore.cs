using InterviewAssigment.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace InterviewAssigment.AuthHelpers
{
    public class CustomUserStore : IUserStore<ApplicationUser, string>, IUserPasswordStore<ApplicationUser, string>, IUserEmailStore<ApplicationUser, string>, IUserLockoutStore<ApplicationUser, string>, IUserTwoFactorStore<ApplicationUser, string>
    {
        public Task CreateAsync(ApplicationUser user)
        {
            return Task.FromResult<object>(null);
        }

        public Task DeleteAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task<ApplicationUser> FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> FindByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            ApplicationUser result = new ApplicationUser();

            var user = new AuthUser() { UserId = "1", UserName = userName };//authenticationRepository.FindUser(userName);
            result = user == null ? null : new ApplicationUser()
            {
                AppUser = user
            };
            #region GetToken
            var identity = new ClaimsIdentity("JWT");
            result.Claims.Add(new UserClaim() { ClaimType = ClaimTypes.Name, ClaimValue = userName });

            //var clientId = "099153c2625149bc8ecb3e85e03f0022";
            //var props = new AuthenticationProperties(new Dictionary<string, string>
            //	{
            //		{
            //			 "audience", clientId
            //		}
            //	});
            //result.AppUser.Token = new CustomJwtFormat("http://localhost:54451").GenerateToken(clientId, DateTime.Now, DateTime.Now.AddMinutes(30), identity.Claims);
            #endregion

            return result;
        }

        public Task<int> GetAccessFailedCountAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetEmailAsync(ApplicationUser user)
        {
            return null;
        }

        public Task<bool> GetEmailConfirmedAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetLockoutEnabledAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<DateTimeOffset> GetLockoutEndDateAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetPasswordHashAsync(ApplicationUser user)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(user.PasswordHash);
            return System.Convert.ToBase64String(plainTextBytes);

        }

        public Task<bool> GetTwoFactorEnabledAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<int> IncrementAccessFailedCountAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task ResetAccessFailedCountAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailAsync(ApplicationUser user, string email)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailConfirmedAsync(ApplicationUser user, bool confirmed)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEnabledAsync(ApplicationUser user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEndDateAsync(ApplicationUser user, DateTimeOffset lockoutEnd)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash)
        {
            return Task.FromResult<object>(null);
        }

        public Task SetTwoFactorEnabledAsync(ApplicationUser user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
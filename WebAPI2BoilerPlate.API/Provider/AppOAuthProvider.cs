using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAPI2BoilerPlate.Business;

namespace WebAPI2BoilerPlate.Provider
{
    public class AppOAuthProvider : OAuthAuthorizationServerProvider
    {

        #region Grant resource owner credentials override method.

        /// <summary>
        /// Grant resource owner credentials overload method.
        /// </summary>
        /// <param name="context">Context parameter</param>
        /// <returns>Returns when task is completed</returns>
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            // Initialization.
            string usernameVal = context.UserName;
            string passwordVal = context.Password;

            CustomerService customerService = new CustomerService();
            var user = customerService.GetUser(usernameVal, passwordVal);

            // Verification.
            if (user == null)
            {
                // Settings.
                context.SetError("Invalid User", "The user name or password is incorrect.");
                return;
            }

            // Initialization.
            var claims = new List<Claim>();
            var userInfo = user;

            claims.Add(new Claim(ClaimTypes.Name, userInfo.UserName));

            // Setting Claim Identities for OAUTH 2 protocol.
            ClaimsIdentity oAuthClaimIdentity = new ClaimsIdentity(claims, OAuthDefaults.AuthenticationType);
            ClaimsIdentity cookiesClaimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);

            // Setting user authentication.
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthClaimIdentity, new AuthenticationProperties());

            // Grant access to authorize user.
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesClaimIdentity);
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.Yield(); // suppress CS1998
            context.Validated();
        }
        #endregion
    }
}
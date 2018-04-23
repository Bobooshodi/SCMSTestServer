using Microsoft.AspNet.Identity.EntityFramework;
using SCMSTestServer.Repository;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Routing;

namespace SCMSTestServer.Controllers.Auth
{
    public class ModelFactory
    {
        private UrlHelper _UrlHelper;
        private AuthProvider _AppUserManager;

        public ModelFactory(HttpRequestMessage request, AuthProvider appUserManager)
        {
            _UrlHelper = new UrlHelper(request);
            _AppUserManager = appUserManager;
        }

        public UserReturnModel Create(IdentityUser appUser)
        {
            return new UserReturnModel
            {
                Url = _UrlHelper.Link("GetUserById", new { id = appUser.Id }),
                Id = appUser.Id,
                UserName = appUser.UserName,
                Email = appUser.Email,
                EmailConfirmed = appUser.EmailConfirmed,
                Roles = _AppUserManager.GetRolesAsync(appUser.Id).Result,
                Claims = _AppUserManager.GetClaimsAsync(appUser.Id).Result
            };
        }

        public UserReturnModel Create(Models.User appUser, bool emailConfirmed)
        {
            return new UserReturnModel
            {
                Url = _UrlHelper.Link("GetUserById", new { id = appUser.ID }),
                Id = appUser.ID,
                UserName = appUser.Username,
                EmailConfirmed = emailConfirmed,
            };
        }
    }

    public class UserReturnModel
    {
        public string Url { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IList<string> Roles { get; set; }
        public IList<System.Security.Claims.Claim> Claims { get; set; }
    }
}
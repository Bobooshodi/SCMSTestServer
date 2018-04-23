using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace SCMSTestServer.Repository
{
    public class AuthProvider : UserManager<IdentityUser>
    {
        public AuthProvider(IUserStore<IdentityUser> store)
            : base(store)
        {
        }

        public static AuthProvider Create(IdentityFactoryOptions<AuthProvider> options, IOwinContext context)
        {
            var appDbContext = context.Get<AuthContext>();

            return new AuthProvider(new UserStore<IdentityUser>(appDbContext));
        }
    }
}
using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/shc-tenants")]
    public class SHCTenantController : BaseController<SHCTenant, SHCTenantsService>
    {
    }
}
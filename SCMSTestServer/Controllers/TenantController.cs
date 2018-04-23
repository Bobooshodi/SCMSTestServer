using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/tenants")]
    public class TenantController : BaseController<Tenant, TenantsService>
    {
    }
}
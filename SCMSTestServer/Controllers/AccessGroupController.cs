using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/access-groups")]
    public class AccessGroupController : BaseController<AccessGroup, AccessGroupsService>
    {
    }
}
using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/buildings")]
    public class BuildingController : BaseController<Building, BuildingService>
    {
    }
}
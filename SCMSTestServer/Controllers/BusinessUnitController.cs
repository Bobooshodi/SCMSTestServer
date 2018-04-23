using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/business-units")]
    public class BusinessUnitController : BaseController<BusinessUnit, BusinessUnitsService>
    {
    }
}
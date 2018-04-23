using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/personalisation-requests")]
    public class PersonalisationRequestController : BaseController<SOAPersonalizationRequest, PersonalisationRequestsService>
    {
    }
}
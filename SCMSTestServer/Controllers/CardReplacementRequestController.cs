using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/card-replacements")]
    public class CardReplacementRequestController : BaseController<SOAReplaceCardRequest, CardReplacementService>
    {
    }
}
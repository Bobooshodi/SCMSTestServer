using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/cards")]
    public class CardController : BaseController<Card, CardService>
    {
    }
}
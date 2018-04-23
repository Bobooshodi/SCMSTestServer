using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/card-vendors")]
    public class CardVendorController : BaseController<CardVendor, CardVendorService>
    {
    }
}
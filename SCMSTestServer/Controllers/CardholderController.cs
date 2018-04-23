using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/cardholders")]
    public class CardholderController : BaseController<Cardholder, CardholderService>
    {
    }
}
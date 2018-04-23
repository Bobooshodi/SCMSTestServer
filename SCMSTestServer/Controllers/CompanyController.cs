using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/companies")]
    public class CompanyController : BaseController<Company, CompanyService>
    {
    }
}
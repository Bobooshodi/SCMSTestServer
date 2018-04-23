using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeeController : BaseController<Employee, EmployeeService>
    {
    }
}
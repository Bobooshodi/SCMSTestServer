using SCMSTestServer.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCMSTestServer.Services
{
    public class EmployeeService : BaseService<Employee, EmployeeService>
    {
        private CardholderService cardholderService = CardholderService.ServiceInstance;

        public override List<Employee> GetAll()
        {
            return AllObjects ??
                (AllObjects = cardholderService.AllObjects?
                              .Where(c => c.UserType == SHCCardType.Employee)
                              .Cast<Employee>().ToList());
        }
    }
}
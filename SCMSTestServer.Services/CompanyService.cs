using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class CompanyService : BaseService<Company, CompanyService>
    {
        public override List<Company> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.Companies(10));
        }
    }
}
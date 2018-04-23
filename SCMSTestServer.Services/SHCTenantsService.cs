using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class SHCTenantsService : BaseService<SHCTenant, SHCTenantsService>
    {
        public override List<SHCTenant> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.SHCTenants(10));
        }
    }
}
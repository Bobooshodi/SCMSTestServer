using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class CardVendorService : BaseService<CardVendor, CardVendorService>
    {
        public override List<CardVendor> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.CardVendors(10));
        }
    }
}
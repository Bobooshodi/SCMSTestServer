using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class CardDistributionRequestService : BaseService<SOACardRequest, CardDistributionRequestService>
    {
        public override List<SOACardRequest> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.CardRequests(10));
        }
    }
}
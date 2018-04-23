using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class CardReplacementService : BaseService<SOAReplaceCardRequest, CardReplacementService>
    {
        public override List<SOAReplaceCardRequest> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.ReplaceCardRequests(10));
        }
    }
}
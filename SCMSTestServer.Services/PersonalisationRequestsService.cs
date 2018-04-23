using SCMSTestServer.Models;
using System;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class PersonalisationRequestsService : BaseService<SOAPersonalizationRequest, PersonalisationRequestsService>
    {
        public override List<SOAPersonalizationRequest> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.PersonalizationRequests(10));
        }
    }
}
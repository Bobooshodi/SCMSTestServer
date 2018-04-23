using System.Collections.Generic;
using SCMSTestServer.Models;

namespace SCMSTestServer.Services
{
    public class AccessGroupsService : BaseService<AccessGroup, AccessGroupsService>
    {
        public override List<AccessGroup> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.AccessGroups(50));
        }
    }
}
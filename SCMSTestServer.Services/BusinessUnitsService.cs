using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class BusinessUnitsService : BaseService<BusinessUnit, BusinessUnitsService>
    {
        public override List<BusinessUnit> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.BusinessUnits(10));
        }
    }
}
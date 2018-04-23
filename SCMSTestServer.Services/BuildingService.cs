using SCMSTestServer.Models;
using System;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class BuildingService : BaseService<Building, BuildingService>
    {
        public override List<Building> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.Buildings(10));
        }
    }
}
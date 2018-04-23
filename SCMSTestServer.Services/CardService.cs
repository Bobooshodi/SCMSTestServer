using SCMSTestServer.Models;
using System.Collections.Generic;

namespace SCMSTestServer.Services
{
    public class CardService : BaseService<Card, CardService>
    {
        public override List<Card> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.Cards(100));
        }
    }
}
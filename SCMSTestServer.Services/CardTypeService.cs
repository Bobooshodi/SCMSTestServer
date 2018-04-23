using SCMSTestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMSTestServer.Services
{
    public class CardTypeService : BaseService<CardType, CardTypeService>
    {
        public override List<CardType> GetAll()
        {
            return AllObjects ?? (AllObjects = MockDataService.CardTypes());
        }
    }
}
using SCMSTestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCMSTestServer.Services
{
    public class CardholderService : BaseService<Cardholder, CardholderService>
    {
        public override List<Cardholder> GetAll()
        {
            return AllObjects ?? (AllObjects = GetCardholders());
        }

        private List<Cardholder> GetCardholders()
        {
            var cardholders = MockDataService.Cardholders(100);
            var result = new List<Cardholder>();

            foreach (var cardholder in cardholders)
            {
                if (cardholder.UserType == SHCCardType.Employee)
                {
                    result.Add(MockDataService.GenerateEmployee(cardholder));
                }
                else if (cardholder.UserType == SHCCardType.Tenant)
                {
                    result.Add(MockDataService.GenerateTenant(cardholder));
                }
            }

            return result;
        }
    }
}
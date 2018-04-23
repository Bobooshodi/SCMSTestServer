using SCMSTestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMSTestServer.Services
{
    public class TenantsService : BaseService<Tenant, TenantsService>
    {
        private CardholderService cardholderService = CardholderService.ServiceInstance;

        public override List<Tenant> GetAll()
        {
            return AllObjects ??
                (AllObjects = cardholderService.AllObjects?
                              .Where(c => c.UserType == SHCCardType.Tenant)
                              .Cast<Tenant>().ToList());
        }
    }
}
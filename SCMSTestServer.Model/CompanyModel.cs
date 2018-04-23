using System.Collections.Generic;

namespace SCMSTestServer.Models
{
    public class Company : BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<BusinessUnit> BusinessUnits { get; set; }
    }
}
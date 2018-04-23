using System.Collections.Generic;

namespace SCMSTestServer.Models
{
    public class BusinessUnit : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CardType> CardTypes { get; set; }
        public List<Company> Companies { get; set; }
    }
}
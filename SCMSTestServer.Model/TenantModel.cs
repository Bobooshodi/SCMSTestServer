namespace SCMSTestServer.Models
{
    public class Tenant : Cardholder
    {
        public Tenant()
        {
            SHCTenant = new SHCTenant();
        }

        public SHCTenant SHCTenant { get; set; }
    }
}
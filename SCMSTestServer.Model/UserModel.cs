namespace SCMSTestServer.Models
{
    public class User : BaseModel
    {
        public int Expires_in { get; set; }

        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get; set;
        }

        public string Token_type
        {
            get; set;
        }

        public string Client_id
        {
            get; set;
        }

        public string Refresh_token
        {
            get; set;
        }

        public string Access_token
        {
            get; set;
        }

        public string Grant_type
        {
            get; set;
        }
    }

    public class PasswordChangeModel
    {
        public string OldPassword
        {
            get;
            set;
        }

        public string NewPassword
        {
            get; set;
        }

        public string ConfirmPassword
        {
            get; set;
        }
    }
}
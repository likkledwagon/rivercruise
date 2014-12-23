using System.ComponentModel;

namespace RiverCruise.Models.Account
{
    public class User
    {
        [DisplayName("Username")]
        public string UserName { get; set; }

        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
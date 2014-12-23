namespace RiverCruise.Models.UserManagement
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool CanEdit { get; set; }
    }
}
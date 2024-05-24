namespace GT_Web.Models
{
    public class ProfileViewModel
    {
        public BLL.Models.ProfileInfo ProfileInfo { get; set; }
        public List<string> AvailableGames { get; set; }
        public List<string> SelectedGames { get; set; }
    }
}

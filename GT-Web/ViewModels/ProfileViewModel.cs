using BLL.Models;

namespace GT_Web.Models
{
    public class ProfileViewModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Platform { get; set; }
        public int Fun { get; set; }
        public int Competitive { get; set; }
        public int Serious { get; set; }
        public int Communication { get; set; }
        public int Dedication { get; set; }
        public List<string> AvailableGames { get; set; }
        public List<string> SelectedGames { get; set; }

        public ProfileInfo ConvertTo(ProfileViewModel profileViewModel)
        {
            ProfileInfo profileInfo = new ProfileInfo(profileViewModel.UserID, profileViewModel.Username, profileViewModel.Bio, profileViewModel.Region, profileViewModel.Country, profileViewModel.Platform, profileViewModel.Fun, profileViewModel.Competitive, profileViewModel.Serious, profileViewModel.Communication, profileViewModel.Dedication);

            return profileInfo;
        }

        public ProfileViewModel ConvertTo(ProfileInfo profileInfo)
        {
            ProfileViewModel profileViewModel = new ProfileViewModel();
            profileViewModel.UserID = profileInfo.UserID;
            profileViewModel.Username = profileInfo.Username;
            profileViewModel.Bio = profileInfo.Bio;
            profileViewModel.Region = profileInfo.Region;
            profileViewModel.Country = profileInfo.Country;
            profileViewModel.Platform = profileInfo.Platform;
            profileViewModel.Fun = profileInfo.Fun;
            profileViewModel.Competitive = profileInfo.Competitive;
            profileViewModel.Serious = profileInfo.Serious;
            profileViewModel.Communication = profileInfo.Communication;
            profileViewModel.Dedication = profileInfo.Dedication;
        }
    }
}

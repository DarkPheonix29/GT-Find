namespace BLL.Models
{
    public class ProfileInfo
    {
        public int UserID { get; }
        public string Username { get; }
        public string Bio { get; }
        public string Region { get; }
        public string Country { get; }
        public string Platform { get; }
        public int Fun { get; }
        public int Competitive { get; }
        public int Serious { get; }
        public int Communication { get; }
        public int Dedication { get; }

        public ProfileInfo(int userId, string username, string bio, string region, string country, string platform, int fun, int competitive, int serious, int communication, int dedication)
        {
            UserID = userId;
            Username = username;
            Bio = bio;
            Region = region;
            Country = country;
            Platform = platform;
            Fun = fun;
            Competitive = competitive;
            Serious = serious;
            Communication = communication;
            Dedication = dedication;
        }
    }
}

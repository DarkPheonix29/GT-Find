public class User
{
    public string Username { get; }
    public int UserId { get; }

    public User(string username, int userId)
    {
        Username = username;
        UserId = userId;
    }
}

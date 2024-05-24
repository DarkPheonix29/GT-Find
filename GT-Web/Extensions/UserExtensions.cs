using System.Security.Claims;

public static class UserExtensions
{
    public static int GetUserId(this ClaimsPrincipal user)
    {
        if (user == null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        var userIdClaim = user.FindFirst("UserId");
        if (userIdClaim == null)
        {
            throw new InvalidOperationException("User ID claim not found.");
        }

        return int.Parse(userIdClaim.Value);
    }
}

using System.Security.Claims;

namespace GT_Web.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst("UserId").Value);
        }
    }
}

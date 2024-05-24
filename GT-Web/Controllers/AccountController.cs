using BLL;
using DAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GT_Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGTService _gtService;

        public AccountController(IGTService gtService)
        {
            _gtService = gtService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("LoginView");
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var hashedPasswordFromDatabase = _gtService.RetrievePass(username);

            if (!string.IsNullOrEmpty(hashedPasswordFromDatabase))
            {
                if (AuthManager.ValidateUser(password, hashedPasswordFromDatabase))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, username),
                        new Claim("UserId", _gtService.RetrieveUserId(username).ToString())
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                    TempData["Message"] = "Login successful!";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "User not found.");
            }

            return View("LoginView");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View("SignUpView");
        }

        [HttpPost]
        public IActionResult SignUp(string email, string username, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match. Please re-enter your password.");
                return View("SignUpView");
            }

            var hashedPassword = AuthManager.SecurePassword(password);

            bool accountCreated = _gtService.CreateAccount(email, hashedPassword, username);

            if (accountCreated)
            {
                TempData["Message"] = "Account Created!";
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Failed to create account. Please try again later.");
            }

            return View("SignUpView");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}

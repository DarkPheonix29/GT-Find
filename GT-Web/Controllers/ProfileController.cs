using BLL;
using BLL.Models;
using BLL.Validators;
using GT_Web.Extensions;
using GT_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GT_Web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IGTService _gtService;

        public ProfileController(IGTService gtService)
        {
            _gtService = gtService;
        }

        public IActionResult Index()
        {
            var userId = User.GetUserId();
            var profileInfo = _gtService.RetrieveProfile(userId);
            if (profileInfo == null)
            {
                return NotFound("Profile not found.");
            }

            var availableGames = _gtService.RetrieveGames();
            var userGames = _gtService.GetUserGames(userId);

            var viewModel = ProfileViewModel.FromProfileInfo(profileInfo);
            viewModel.AvailableGames = availableGames;
            viewModel.SelectedGames = userGames;

            Debug.WriteLine($"Profile Info: UserID = {profileInfo.UserID}, Username = {profileInfo.Username}");
            Debug.WriteLine($"User ID from claims: {userId}");

            return View("ProfileView", viewModel);
        }

        [HttpPost]
        public IActionResult SaveProfile(ProfileViewModel viewModel)
        {
            try
            {
                var profileInfo = viewModel.ToProfileInfo(User.GetUserId(), User.Identity.Name);

                if (!Validator.IsValidCountry(profileInfo.Country))
                {
                    TempData["Error"] = "Invalid country.";
                    return RedirectToAction("Index");
                }

                if (!Validator.IsValidRegion(profileInfo.Region))
                {
                    TempData["Error"] = "Invalid region.";
                    return RedirectToAction("Index");
                }

                if (!Validator.IsValidPlatform(profileInfo.Platform))
                {
                    TempData["Error"] = "Invalid platform.";
                    return RedirectToAction("Index");
                }

                if (!Validator.IsValidUsername(profileInfo.Username))
                {
                    TempData["Error"] = "Username cannot be longer than 20 characters.";
                    return RedirectToAction("Index");
                }

                var success = _gtService.SaveProfile(
                    profileInfo.UserID,
                    profileInfo.Username,
                    profileInfo.Bio,
                    profileInfo.Region,
                    profileInfo.Country,
                    profileInfo.Platform,
                    profileInfo.Fun,
                    profileInfo.Competitive,
                    profileInfo.Serious,
                    profileInfo.Communication,
                    profileInfo.Dedication
                );

                if (success)
                {
                    success = _gtService.SaveUserGames(profileInfo.UserID, viewModel.SelectedGames);
                    if (success)
                    {
                        TempData["Message"] = "Profile saved successfully!";
                    }
                    else
                    {
                        TempData["Error"] = "Failed to save selected games!";
                    }
                }
                else
                {
                    TempData["Error"] = "Failed to save profile!";
                }
            }
            catch (ArgumentException ex)
            {
                TempData["Error"] = $"An error occurred: {ex.Message}";
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"An error occurred: {ex.Message}";
            }

            return RedirectToAction("Index");
        }
    }
}

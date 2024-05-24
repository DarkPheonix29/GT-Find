using BLL;
using GT_Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace GT_Web.Controllers
{
    public class FindController : Controller
    {
        private readonly IGTService _gtService;

        public FindController(IGTService gtService)
        {
            _gtService = gtService;
        }

        public IActionResult Index()
        {
            var currentUserId = User.GetUserId();
            var userMatching = new UserMatching(_gtService);
            var potentialMatches = userMatching.FindMatches(currentUserId);

            Debug.WriteLine($"Number of potential matches: {potentialMatches.Count}");

            return View("FindView", potentialMatches); // Change this line
        }
    }
}

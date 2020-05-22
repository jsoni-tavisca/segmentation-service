using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Optimizely.Poc.Models;
using OptimizelySDK;
using OptimizelySDK.Entity;

namespace Optimizely.Poc.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private static OptimizelySDK.Optimizely _client;
        private static string experiment_key = "optimizely_poc";
        private static string visualStudio_Btn_Event = "visual_studio_btn_event";
        private static string hyperLink_Click_Event = "hyperlink_click_event";


        public HomeController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _client = OptimizelyFactory.NewDefaultInstance("3sRxUTdRcAr71AUmFcKc98");
        }

        public IActionResult Index()
        {
            ViewBag.Assignment = GetHyperlinkTextAssignment();
            ViewBag.Target = GetTabOpeningAssignment();



            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private string GetTabOpeningAssignment()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var target = string.Empty;

            var userAttributes = new UserAttributes
            {
                {"userType", HttpContext.User.Identity.Name }
            };

            var variation = _client.GetVariation(experiment_key, userId, userAttributes);

            if (variation?.Key.Equals("variation_1") ?? false)
                target = "_blank";
            else if (variation?.Key.Equals("variation_2") ?? false)
                target = "_self";

            return target;
        }

        private string GetHyperlinkTextAssignment()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var userName = HttpContext.User.Identity.Name;
            var assignment = string.Empty;

            var userAttributes = new UserAttributes
            {
                {"userType", HttpContext.User.Identity.Name }
            };

            var variation = _client.GetVariation(experiment_key, userId, userAttributes);

            if (variation?.Key.Equals("variation_1") ?? false)
                assignment = "Platform_Common";
            else if (variation?.Key.Equals("variation_2") ?? false)
                assignment = "Nuget";

            return assignment;
        }

        [HttpGet]
        public void RecordTabImpression()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var userName = HttpContext.User.Identity.Name;
            var assignment = string.Empty;

            var userAttributes = new UserAttributes
            {
                {"userType", HttpContext.User.Identity.Name }
            };

            var variation = _client.Activate(experiment_key, userId, userAttributes);
        }


        [HttpGet]
        public void RecordHyperlinkTextImpression()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var userName = HttpContext.User.Identity.Name;
            var assignment = string.Empty;

            var userAttributes = new UserAttributes
            {
                {"userType", HttpContext.User.Identity.Name }
            };

            var variation = _client.Activate(experiment_key, userId, userAttributes);
        }

        [HttpGet]
        public void RecordVisualStudioButtonAction()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var userName = HttpContext.User.Identity.Name;
            var assignment = string.Empty;

            var userAttributes = new UserAttributes
            {
                {"userType", HttpContext.User.Identity.Name }
            };

            var tags = new EventTags
            {
                {
                "revenue","1000"
                },
                {
                    "value", "500"
                }
            };
            _client.Track(visualStudio_Btn_Event, userId, userAttributes);
        }

        [HttpGet]
        public void RecordHyperLinkClickAction()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var userName = HttpContext.User.Identity.Name;
            var assignment = string.Empty;

            var userAttributes = new UserAttributes
            {
                {"userType", HttpContext.User.Identity.Name }
            };

            _client.Track(hyperLink_Click_Event, userId, userAttributes);
        }
    }
}

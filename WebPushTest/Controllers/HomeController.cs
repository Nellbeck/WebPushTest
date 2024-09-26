using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebPushTest.Models;
using WebPush;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace WebPushTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.applicationServerKey = configuration["VAPID:publicKey"];
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string client, string endpoint, string p256dh, string auth)
        //{
        //    if (client == null)
        //    {
        //        return BadRequest("No Client Name parsed.");
        //    }
        //    if (.Contains(client))
        //    {
        //        return BadRequest("Client Name already used.");
        //    }
        //    var subscription = new PushSubscription(endpoint, p256dh, auth);
        //    ProtectedLocalStorage(client, subscription);
        //    return View("Notify", PersistentStorage.GetClientNames());
        //}
    }
}

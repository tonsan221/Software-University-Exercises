﻿using SUS.HTTP;
using SUS.MvcFramework;

namespace SharedTrip.Controllers
{
    class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse Index()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/Trips/All");
            }
            return this.View();
        }
    }
}
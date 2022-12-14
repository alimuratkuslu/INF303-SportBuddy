using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace Sport_Buddy.Controllers
{
    public class LocationController : Controller
    {

        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        public IActionResult Index()
        {
            var values = locationService.GetAllLocations();
            return View(values);
        }
    }
}


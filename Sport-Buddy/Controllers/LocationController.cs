using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
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

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Location location)
        {
            locationService.SaveLocation(location);
            return View();
        }

        public IActionResult Delete(int id)
        {
            var location = locationService.GetById(id);
            locationService.DeleteLocation(location);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var location = locationService.GetById(id);
            return View(location);
        }

        public IActionResult Edit(Location location)
        {
            locationService.UpdateLocation(location);
            return RedirectToAction("Index");
        }
    }
}


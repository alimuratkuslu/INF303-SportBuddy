using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Sport_Buddy.Controllers
{
    public class ActivityController : Controller
    {

        private readonly IActivityService activityService;

        public ActivityController(IActivityService activityService)
        {
            this.activityService = activityService;
        }

        public IActionResult Index()
        {
            var values = activityService.GetAllActivities();
            return View(values);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Activity activity)
        {
            activityService.SaveActivity(activity);
            return View();
        }

        public IActionResult Delete(int id)
        {
            var activity = activityService.GetById(id);
            activityService.DeleteActivity(activity);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var activity = activityService.GetById(id);
            return View(activity);
        }

        public IActionResult Edit(Activity activity)
        {

            activityService.UpdateActivity(activity);
            return RedirectToAction("Index");
        }
    }
}


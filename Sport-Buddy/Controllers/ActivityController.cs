using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
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
    }
}


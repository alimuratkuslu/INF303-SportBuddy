using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Sport_Buddy.Controllers
{
    public class ActivityController : Controller
    {

        private readonly IActivityService activityService;

        private readonly Context _context;

        public ActivityController(IActivityService activityService, Context context)
        {
            this.activityService = activityService;
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.activity
                .Include(u => u.user1)
                .Include(u => u.user2)
                .Include(u => u.Location)
                .ToList();
            
            var values = activityService.GetAllActivities();

            return View(list);
            
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sport_Buddy.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;
        private readonly IHttpContextAccessor _accessor;

        public LoginController(Context context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        
        public IActionResult Profile()
        {

            ViewBag.username = HttpContext.Session.GetString("username");
            ViewBag.name = _context.customer.SingleOrDefault(x => x.username == HttpContext.Session.GetString("username")).name;
            ViewBag.surname = _context.customer.SingleOrDefault(x => x.username == HttpContext.Session.GetString("username")).surname;
            ViewBag.email = _context.customer.SingleOrDefault(x => x.username == HttpContext.Session.GetString("username")).email;
            ViewBag.phone = _context.customer.SingleOrDefault(x => x.username == HttpContext.Session.GetString("username")).phone;
            ViewBag.address = _context.customer.SingleOrDefault(x => x.username == HttpContext.Session.GetString("username")).address;
            ViewBag.birth_date = _context.customer.SingleOrDefault(x => x.username == HttpContext.Session.GetString("username")).birth_date;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Customer c)
        {

            var info = _context.customer.FirstOrDefault(x => x.username == c.username
            && x.password == c.password);

            if(info != null)
            {
                HttpContext.Session.SetString("username", c.username);
                
                //HttpContext.Session.SetString("surname", c.surname);

                /*
                HttpContext.Session.SetString("name", c.name);
                HttpContext.Session.SetString("surname", c.surname);
                HttpContext.Session.SetString("email", c.email);
                HttpContext.Session.SetString("phone", c.phone);
                HttpContext.Session.SetString("address", c.address);
                HttpContext.Session.SetString("birth_date", c.birth_date.ToString());
                */

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, c.username)
                    
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
                
            }

            else
            {
                ViewBag.msg = "You have entered wrong credentials. Please Try Again!";
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return View("Login", "Login");
        }
    }
}
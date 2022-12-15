using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Sport_Buddy.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            var values = customerService.GetAllCustomers();
            return View(values);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Customer customer)
        {
            customerService.SaveCustomer(customer);
            return View();
        }

        public IActionResult Delete(int id)
        {
            var customer = customerService.GetById(id);
            customerService.DeleteCustomer(customer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = customerService.GetById(id);
            return View(customer);
        }

        public IActionResult Edit(Customer customer)
        {

            customerService.UpdateCustomer(customer);
            return RedirectToAction("Index");
        }
    }
}


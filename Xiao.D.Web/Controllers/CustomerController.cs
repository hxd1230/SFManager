using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xiao.D.Core.Domain.Customers;
using Xiao.D.Services.Customers;
using Xiao.D.Web.Models.Customers;

namespace Xiao.D.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerModel model)
        {
            var customer = new Customer
            {
                UserName = model.UserName,
                Password = model.Password,
                Enable = true,
                CreatedOnUtc = DateTime.Now
            };
            _customerService.InsertCustomer(customer);
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
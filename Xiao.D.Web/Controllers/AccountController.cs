using System.Web.Mvc;
using Xiao.D.Core.Domain.Customers;
using Xiao.D.Services.Customers;

namespace Xiao.D.Web.Controllers
{
    public class AccountController : Controller
    {
        private ICustomerService _customerService;
        public AccountController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public ActionResult Login()
        {
            Customer user = _customerService.GetUserById(5);
            return View(user);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xiao.D.Web.Models.Customers
{
    public class CustomerModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Enable { get; set; }
    }
}
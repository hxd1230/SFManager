using System;

namespace Xiao.D.Core.Domain.Customers
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            this.CustomerGuid = Guid.NewGuid();
        }
        public Guid CustomerGuid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool Enable { get; set; }
    }
}

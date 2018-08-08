using System;
using Xiao.D.Core.Data;
using Xiao.D.Core.Domain.Customers;
using Xiao.D.Data;
namespace Xiao.D.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository = new EFRepository<Customer>();
        //public UserService(IRepository<UserEntity> userRepository)
        //{
        //    _userRepository = userRepository;
        //}
        public virtual Customer GetUserById(int userId)
        {
            if (userId == 0)
            {
                return null;
            }
            return _customerRepository.GetById(userId);
        }
        public virtual void InsertCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("customer");
            _customerRepository.Insert(customer);
        }
    }
}

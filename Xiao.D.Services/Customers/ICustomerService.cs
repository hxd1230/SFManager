using Xiao.D.Core.Domain.Customers;

namespace Xiao.D.Services.Customers
{
    public interface ICustomerService
    {
        Customer GetUserById(int userId);
        void InsertCustomer(Customer customer);
    }
}

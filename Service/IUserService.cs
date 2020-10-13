using Model;
using System.Collections.Generic;

namespace Service
{
    public interface IUserService : IBaseService<User>
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Employee> GetAllEmployees();
    }
}

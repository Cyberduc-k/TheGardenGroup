using Model;
using System.Collections.Generic;

namespace DAL
{
    public interface IUserRepository : IBaseRepository<User>
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Employee> GetAllEmployees();
    }
}

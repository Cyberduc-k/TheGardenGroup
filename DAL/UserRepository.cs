using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DAL
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository() : base("Users") { }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return collEntities.AsQueryable()
                                .Where(((Expression<Func<User, bool>>)(user => user is Customer)).Compile())
                                .Select(user => (Customer)user)
                                .ToList();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return collEntities.AsQueryable()
                                .Where(((Expression<Func<User, bool>>)(user => user is Employee)).Compile())
                                .Select(user => (Employee)user)
                                .ToList();
        }
    }
}

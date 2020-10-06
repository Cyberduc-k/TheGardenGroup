using Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _users;

        public UserService(IUserRepository users)
        {
            _users = users;
        }

        public long Count()
        {
            return _users.Count();
        }

        public User GetSingle(string id)
        {
            return _users.GetSingle(id);
        }

        public User GetSingleBy(Expression<Func<User, bool>> predicate)
        {
            return _users.GetSingleBy(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            return _users.GetAll();
        }

        public IEnumerable<User> GetAllBy(Expression<Func<User, bool>> predicate)
        {
            return _users.GetAllBy(predicate);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Update(User user)
        {
            _users.Update(user);
        }

        public void Delete(User user)
        {
            _users.Delete(user);
        }

        public void DeleteBy(Expression<Func<User, bool>> predicate)
        {
            _users.DeleteBy(predicate);
        }
    }
}

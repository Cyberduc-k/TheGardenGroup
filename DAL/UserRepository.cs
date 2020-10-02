using Model;

namespace DAL
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository() : base("Users") { }
    }
}

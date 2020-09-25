using Model;

namespace DAL
{
    public class UserRepository : EntityBaseRepository<User>
    {
        public UserRepository() : base("Users") { }
    }
}

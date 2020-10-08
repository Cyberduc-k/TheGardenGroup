using Model;

namespace Service
{
    public class LoggedInUser
    {
        //A singelton pattern to optimize overhead
        private static LoggedInUser instance;
        private User user;

        public static LoggedInUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoggedInUser();

                return instance;
            }
        }

        private LoggedInUser() { }

        public User User { get; set; }
    }
}

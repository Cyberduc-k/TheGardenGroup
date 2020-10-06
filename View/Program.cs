using DAL;
using Service;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            ServiceProvider provider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(provider));
        }
    }
}

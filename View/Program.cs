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

            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketService, TicketService>();

            services.AddTransient<IFAQRepository, FAQRepository>();
            services.AddScoped<IFAQService, FAQService>();

            services.AddTransient<IErrorRepository, ErrorRepository>();
            services.AddScoped<IErrorService, ErrorService>();


            ServiceProvider provider = services.BuildServiceProvider();

            //Make sure the ErrorHandler is initialized with a service provider
            ErrorHandler.Instance.Setup(provider);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login(provider));
            Application.Run(new Submit_Ticket(provider));
            Application.Run(new FAQForm(provider));
            Application.Run(new Statistics_Dashboard(provider));
            Application.Run(new User_Dashboard(provider));
            Application.Run(new Tickets_Dashboard(provider));
        }
    }
}
using System;
using System.Windows.Forms;
using Model;

namespace Service
{
    public class ErrorHandler //Class to handle all the errors thrown in the application
    {
        private IErrorService errorService;

        //A singelton pattern to optimize overhead
        private static ErrorHandler instance;

        public static ErrorHandler Instance
        {
            get
            {
                if (instance == null)
                    instance = new ErrorHandler();

                return instance;
            }
        }

        private ErrorHandler() { }

        public void Setup(IServiceProvider provider)
        {
            errorService = provider.GetService(typeof(IErrorService)) as IErrorService;
        }

        //Function to show and log the error
        public void HandleError(string message, string title, Exception e)
        {
            //Show the error as a popup
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Try to log the error to the database
            try
            {
                errorService.Add(new Error(e.GetType().Name, DateTime.Now, message, e.StackTrace));
            }
            catch (Exception ex) //If there is an error while writing to the db
            {
                MessageBox.Show("De error kon helaas niet in de database gelogd worden", "Loggen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Loggen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
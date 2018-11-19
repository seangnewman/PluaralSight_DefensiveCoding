using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ACM.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //For UI thread exceptions
            Application.ThreadException +=
                new System.Threading.ThreadExceptionEventHandler(GlobalExceptionHandler);

            // For all Windows Form error to go through our handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // For non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException +=
                 new UnhandledExceptionEventHandler(GlobalExceptionHandler);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new OrderWin());
            Application.Run(new PedometerWin());
        }

        private static void GlobalExceptionHandler(object sender, EventArgs args)
        {
            // Log the issue
            MessageBox.Show("There was a problem with this application.  Please contact support");
            System.Windows.Forms.Application.Exit();
        }
    }
}

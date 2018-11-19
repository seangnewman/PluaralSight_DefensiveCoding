using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class EmailLibrary
    {
        public void SendEmail(string emailAddress, string v)
        {
            // I f avalid email address is provided
           

            try
            {
                // Send an email
            }
            catch (InvalidOperationException ex)
            {
                // log the error
                //rethrow the original exception (do not include ex, throws new exception)
                throw;
            }
        }
    }
}

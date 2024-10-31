using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPandDesignPatterns.Coupling
{
    internal class EmailSender
    {
        public void SendEmail(string message)
        {
            //Email sending logic
            Console.WriteLine("Sending email: " + message);
        }
    }
}

﻿namespace OOPandDesignPatterns.Coupling
{
    internal class EmailSender : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email: " + message);
        }
    }
}

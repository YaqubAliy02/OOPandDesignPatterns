namespace OOPandDesignPatterns.Coupling
{
    internal class SmsSender : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Send sms: " + message);
        }
    }
}

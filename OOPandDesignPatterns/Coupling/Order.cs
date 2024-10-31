namespace OOPandDesignPatterns.Coupling
{
    internal class Order
    {
        private readonly INotification notification;

        public Order(INotification notification)
        {
            this.notification = notification;
        }

        public void PlaceOrder()
        {
            //Place order logic
            /* EmailSender emailSender = new EmailSender();
             // In this example every thing work but Order class is tightly coupled
             // to the EmailSender class because it directly creates an instance of the
             // email sender class which makes Order class dependent on the
             // implementation details of EmailSender and any changes to the EmailSender
             // class may require modifications to the Order class
             emailSender.SendEmail("Order pleased successfully");*/
            this.notification.SendNotification("Order placed successfully");

        }
    }
}

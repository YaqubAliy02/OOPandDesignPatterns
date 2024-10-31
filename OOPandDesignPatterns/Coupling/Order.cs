namespace OOPandDesignPatterns.Coupling
{
    internal class Order
    {
        public void PlaceOrder()
        {
            //Place order logic
            EmailSender emailSender = new EmailSender();
            // In this example every thing work but Order class is tightly coupled
            // to the EmailSender class because it directly creates an instance of the
            // email sender class which makes Order class dependent on the
            // implementation details of EmailSender and any changes to the EmailSender
            // class may require modifications to the Order class
            emailSender.SendEmail("Order pleased successfully");
        }
    }
}

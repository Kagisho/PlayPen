using System;

namespace Events.Services
{
    public class MailService
    {
        public void HandleOrderSaveEvent(object sender, ForexOrderEventArgs e)
        {
            Console.WriteLine($"Sending email for {e.Order.AccountNumber}");
        }
    }
}
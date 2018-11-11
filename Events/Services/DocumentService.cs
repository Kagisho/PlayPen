using System;

namespace Events.Services
{
    public class DocumentService
    {
        public void HandleOrderSaveEvent(object sender, ForexOrderEventArgs e)
        {
            Console.WriteLine($"Generating documents for {e.Order.AccountNumber}");
        }
    }
}
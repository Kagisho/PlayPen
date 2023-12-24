using System;
using System.Threading;

namespace Events
{
    public class ForexOrder
    {
        public string AccountNumber { get; set; }
        public EventHandler<ForexOrderEventArgs> OnForexOrderSave;
        public void Save()
        {
            Console.WriteLine($"Saving order, Account: {AccountNumber }...");
            Thread.Sleep(2000);
            OnSaveEvent(this);
        }

        public void OnSaveEvent(ForexOrder order)
        {
            OnForexOrderSave?.Invoke(this, new ForexOrderEventArgs { Order = order });
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Services;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new ForexOrder { AccountNumber = "1574078" };
            var mailService = new MailService();
            var documentService = new DocumentService();

            order.OnForexOrderSave += mailService.HandleOrderSaveEvent;
            order.OnForexOrderSave += documentService.HandleOrderSaveEvent;

            order.Save();

            Console.ReadLine();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
   public class Program
    {
        static void Main(string[] args)
        {
            var eb = new EventBroker();
            var p = new Person(eb);

            eb.Command(new ChangeAgeCommand(p, 24));
            eb.Command(new ChangeAgeCommand(p, 17));
            foreach (var ev in eb.AllEvents)
            {
                Console.WriteLine(ev);
            }

            int age = 0;
            age = eb.Query<int>(new AgeQuery { Target = p });
            Console.WriteLine($"\nCurrent age: "+ age);

            Console.WriteLine("**** Undoing last *****");
            eb.UndoLast();

            age = eb.Query<int>(new AgeQuery { Target = p });
            Console.WriteLine($"\nCurrent age: " + age);
            Console.ReadKey();
        }
    }
}

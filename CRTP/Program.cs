using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTP
{
   
   class Program
    {
        static void Main(string[] args)
        {
            //var derived = new DerivedProblematic();
            //Console.WriteLine("Calling derived: " + derived.DerivedClassProperty);

            //var copyOfDerived = derived.Copy();
            //Console.WriteLine("Calling copy of derived: " + ((DerivedProblematic)copyOfDerived).DerivedClassProperty);

            var derived = new DerivedFixed();
            Console.WriteLine("Calling derived: "+ derived.DerivedClassProperty);

            var copy = derived.Copy();
            
            Console.WriteLine("Calling copy of derived: " + copy.DerivedClassProperty);

            Console.ReadLine();
        }
    }
}

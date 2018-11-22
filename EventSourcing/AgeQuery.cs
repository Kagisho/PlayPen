using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class AgeQuery: Query 
    {
        public Person Target { get; set; }
       
    }
}

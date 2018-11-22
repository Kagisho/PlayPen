using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class Query : EventArgs
    {
        public object Result { get; set; }
    }
}

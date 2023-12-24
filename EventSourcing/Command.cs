using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class Command : EventArgs
    {
        public bool IsRegistering { get; set; } = true;
    }
}

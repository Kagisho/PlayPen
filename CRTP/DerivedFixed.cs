using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTP
{
    public class DerivedFixed : BaseFixed<DerivedFixed>
    {
        public string DerivedClassProperty {
            get { return "Property of derived - fixed"; }
        }

        public override DerivedFixed Copy()
        {
            return this;
        }
    }

}

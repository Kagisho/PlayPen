using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class AgeChangeEvent : Event
    {
        public Person Target { get; set; }
        public int OldValue { get; set; }
        public int NewValue { get; set; }

        public AgeChangeEvent(Person target, int oldValue, int newValue)
        {
            Target = target;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public override string ToString()
        {
            return $"Age changed from {OldValue} to {NewValue}";
        }
    }
}

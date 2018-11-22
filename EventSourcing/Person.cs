using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class Person
    {
        private int age;
        private EventBroker broker;
        
        public Person(EventBroker _broker)
        {
            broker = _broker;

            broker.Commands += ChangeAgeCommand;
            broker.Queries += AgeQuery;
        }

        private void AgeQuery(object sender, Query e)
        {
            if (e != null && e is AgeQuery)
            {
                var t = (AgeQuery)e;
                if (t.Target == this)
                {
                   t.Result = this.age;
                }
            }

        }

        private void ChangeAgeCommand(object sender, Command e)
        {
            if (e != null && e is ChangeAgeCommand)
            {
                var t = (ChangeAgeCommand)e;
                if (t.Target == this)
                {
                    if (t.IsRegistering)
                    {
                        broker.AllEvents.Add(new AgeChangeEvent(this, age, t.Age));
                    }

                    age = t.Age;
                }
            }
        }
    }
}

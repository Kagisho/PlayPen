using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class EventBroker
    {
        public IList<Event> AllEvents = new List<Event>();
        public event EventHandler<Command> Commands;
        public event EventHandler<Query> Queries;

        public void Command(Command command)
        {
            Commands?.Invoke(this, command);
        }

        public void Query(Query query)
        { 
            Queries?.Invoke(this, query);    
        }

        public T Query<T>(Query q)
        {
            Queries?.Invoke(this, q);
            return (T)q.Result;
        }

        public void UndoLast()
        {
            var e = AllEvents.LastOrDefault();
            if (e != null)
            {
                var lastCommand = e as AgeChangeEvent;
                Command(new ChangeAgeCommand(lastCommand.Target, lastCommand.OldValue));
                AllEvents.Remove(e);
            }
        }
    }
}

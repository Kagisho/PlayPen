using System;

namespace Events
{
    public class ForexOrderEventArgs : EventArgs
    {
        public ForexOrder Order { get; set; }
    }
}
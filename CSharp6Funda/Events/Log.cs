using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Log
    {
        //subscribed to event
        public void Subscribe(Clock clock)
        {
            clock.secondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"logtime : {e.Hour}:{e.Minute}:{e.Second}");
        }
    }
}

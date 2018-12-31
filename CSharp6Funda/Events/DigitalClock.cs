using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class DigitalClock
    {
        ////Let's create a little helper method, Subscribe, that's in theClock, and then we're going to register using the += to the SecondChanged event, 
        ///with a method that we're going to call NewTime.
        public void Subscribe(Clock theClock)
        {
            //Step 3 : Register the event at client
            theClock.secondChanged += NewTime;
        }

        public void NewTime(Object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Curren Time : {e.Hour.ToString()}:{e.Minute.ToString()}:{e.Second.ToString()}");
        }
    }
}

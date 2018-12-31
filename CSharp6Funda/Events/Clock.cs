using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    #region Funda : Events
    //We're all familiar with events. They tell you that something has happened, such as the user clicking a button, or a mouse click. It could even be a system event, such as a clock tick or the conclusion of downloading material from a web service. If we were going to build a clock, we would want that clock to broadcast every time the time changes, and then our various instances of clock would want to know about that, they'd want to subscribe to that event so that they could advance the value displayed in the digital clock. To do this, we're going to need to be able to pass data to the client of the clock, and so we'll need to create our own event args, in this case TimeInfoEventArgs, and then the client will consume our event, and with it our TimeInfoEventArgs, and be able to display the time appropriately. For this we need our custom EventArgs, in our case TimeInfoEventArgs, and you can see that that consists of three properties, Hour, Minute, and Second. 
    //The way that we declare an event, in this case of the class Clock, is first by declaring a delegate. Here our delegate is for a method that returns void, but takes two parameters, an object, which will call in clock, and an instance of our custom TimeInfoEventArgs, which we'll call in timeInformation. That delegate we're naming SecondChangeHandler.We then are ready to create our event using the keyword event, tell the event that the delegate is going to use its SecondChangedHandler, and name the event SecondChanged.
   //When we create our DigitalClock, we want it to be able to subscribe to the SecondChanged event on the Clock.Let's create a little helper method, Subscribe, that's in theClock, and then we're going to register using the += to the SecondChanged event, with a method that we're going to call NewTime.Next we want to create another object that can subscribe to the clock
    #endregion
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        //Step 1 : Declare a delegate
        //The way that we declare an event, in this case of the class Clock, is first by declaring a delegate. 
        //Here our delegate is for a method that returns void, but takes two parameters, an object, which will call in clock, 
        //and an instance of our custom TimeInfoEventArgs, which we'll call in timeInformation. That delegate we're naming SecondChangeHandler. 
        //We then are ready to create our event using the keyword event, tell the event that the delegate is going to use its SecondChangedHandler, 
        //and name the event SecondChanged. 

        public delegate void SecondChangedHandler(object clock, TimeInfoEventArgs timeInformation);
        //Setp 2: declare an event with delegate
        //after creating the delegate, create event using the keyword event, tell the event that the delegate is going to use its SecondChangedHandler, and name the event SecondChanged.
        public event SecondChangedHandler secondChanged; 

        public void Run()
        {
            for(; ; ) //infinite loop
            {
                System.Threading.Thread.Sleep(100);
                DateTime now = DateTime.Now;
                if(now.Second != second)
                {
                    //create an instance of our event args : to pass in the current hour,minute and second, that uses the constructor of TimeInfoEventArgs to set the properties Hour,Minute and Second
                    TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);

                    //Now raise the event and check if anyone is registered for event
                    if(secondChanged != null)
                    {
                        secondChanged(this, timeInfoEventArgs);
                    }
                }
            }
        }
    }
}

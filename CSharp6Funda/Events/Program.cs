﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clock clock = new Clock();
            ////create an instance of Clock class which has the event
            //Clock clock = new Clock();
            ////create an instance of client class which are subscribed to the event
            //DigitalClock digitalClock = new DigitalClock();
            //digitalClock.Subscribe(clock);

            //Log log = new Log();
            //log.Subscribe(clock);
            //clock.Run();

            Worker worker = new Worker();
            worker.Work();

            Console.ReadLine();
        }
    }
}

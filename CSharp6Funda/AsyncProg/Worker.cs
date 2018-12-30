using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProg
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            AsyncClass asyncClass = new AsyncClass();
            asyncClass.Work();
            Console.WriteLine("I am on the Main thread");
            for(int i = 0; i <1000;i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("Main thread has completed");
        }
    }

    //Cretaing a new class here to visualise the control flow
    public class AsyncClass
    {
        public async void Work()
        {
            await SlowTask();
            Console.WriteLine("End of Work");
        }

        public async Task SlowTask()
        {
            for(int i =0;i<50;i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j < 1000; j++)
                {
                    var k = Math.Sqrt(j);
                }               
            }
            Console.WriteLine("Slowtask done");
        }
    }
}

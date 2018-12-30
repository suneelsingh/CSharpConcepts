using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var mediaInventory = new MediaInventory();
            var recordPlayer = new RecordPlayer();
            var cassettePlayer = new CassettePlayer();
            //In step 4, we're going to go ahead and instantiate the delegate, notice the keyword new, then the delegate name, TestMedia, 
            //and we're going to pass into it a method that meets its signature, that is that has no parameters and meets its returns value, that is returns bool. 
            MediaInventory.TestMedia testRecordDelegate = new MediaInventory.TestMedia(recordPlayer.PlayRecord);
            MediaInventory.TestMedia testCassetteDelegate = new MediaInventory.TestMedia(cassettePlayer.TestCassette);

            //Finally, in step 5 we're going to invoke that method through the delegate. 
            //So when we say TestResult, we're going to pass in our instance of the delegate, and because that instance of the delegate is holding our PlayRecord method,
            //it's going to play it. 
            mediaInventory.TestResult(testRecordDelegate);
            mediaInventory.TestResult(testCassetteDelegate); //similarly instance of delegate holds the TestCassette method. it's gpoing to test it.
        }
    }
}

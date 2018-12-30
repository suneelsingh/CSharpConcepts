using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    #region Funda: Delegate
    /*
     * Step1. Declare a Delegate (ex. In MediaInventory Class, TestMedia is a delegate)
     * Step2. Create a method to use the delegate (ex. TestResult Method which uses TestMedia delgate as parameter, in MediaInventory class)
     * Setp3. Create one or more method that matches the delegate's return value and parameters
     *     3a. Create another method that matches the delegate's return value and parameters
     * Step4. Initiate the delegate
     * Step5. Invoke the method through the delegate
     */
    #endregion
    #region Implemention
    //MediaInventory is going to declare a delegate. That delegate will be for methods that take no parameters and return a Boolean. We're going to call that delegate TestMedia.
    //We're then going to give MediaInventory a method. Method TestResult is going to take as its argument an instance of the delegate TestMedia, and we'll call that instance mediaDelegate. 
    //We're then going to check, using an if statement, what happens when we invoke a method through that delegate. 
    //Remember, that method is going to return bool so that we can test for true. If that method that we used through the delegate, does in fact return true, 
    //we're going to write "Works. Add to Inventory" to the console. On the other hand, if the method that we are calling through the delegate returns false, 
    //then we're going to write to the console that the media failed and we should reject it. 
    //It's important to note in this if statement that we are invoking the method that the delegate holds, and that's why we have the parens. 
    //Let's go ahead and create some methods that can be called through the delegate. We'll start by creating a RecordPlayer class. Remember record players? 
    //Let's give RecordPlayer a method that matches what the delegate can hold, that is it takes no parameters, and returns bool. We'll call that method PlayRecord, 
    //and we will mimic the idea of testing whether playing a record works by writing to the console.Making the assumption that it does work will return true. 
    //Now let's go and create another method in another class that also meets the criteria of what the delegate can hold, and we'll call that new class CassettePlayer. 
    //So we have a couple retro classes here.In CassettePlayer, we will declare a method that the delegate can hold. TestCassette takes no parameters and returns bool. 
    //TestCassette is going to assume that the testing failed.Since the testing failed, we will return false. 
    //We now have two methods that meet the criteria that they can be held by that delegate, so to test that let's create our Worker class. 
    //Let's jump over the creation of the Worker, we've seen this many times, and focus in on the Work method itself. 
    //We'll start by instantiating the MediaInventory object, and remember it's MediaInventory that has our delegate. 
    //We'll now instantiate a RecordPlayer, and we'll also instantiate a cassettePlayer. Let's get the delegate from MediaInventory, that's called TestMedia, 
    //and we'll call that delegate testRecordDelegate.And the way we instantiate that is to go get our MediaInventory.TestMedia, that's our delegate, 
    //and to pass into it the PlayRecord method which that delegate can hold. Let's create a second instance of our delegate. 
    //We'll call this one TestCassetteDelegate, and we'll initialize it with a new keyword, and that brings us to the TestMedia delegate, 
    //which we will pass into the cassettePlayer.TestCassette method. Now that we have the two delegates, we can call the TestResult method from mediaInventory, 
    //and pass in each of those delegates in turn.So first we'll pass in the TestRecordDelegate, and then we'll pass in the testCassetteDelegate. 
    //And notice the indirection here, we're passing in the delegate rather than passing in the actual method, but testRecordDelegate holds the TestRecord method that returns bool and takes no parameters. 
    //You may want to pause the video and examine these statements and make sure you're comfortable with them. 
    //Let's go back to Main and instantiate our Worker class so that we can set off the Work method. 
    //And you can see that the results are, as we would expect, that we were able to call the TestRecord and the TestCassette method through their respective delegates.
    #endregion
    public class MediaInventory
    {
        //Step 1: Deleare a delegate
        public delegate bool TestMedia(); //in the class MediaInventory, we are declaring a delegate named TestMedia. Notice the keyword delegate. And then what we see is that TestMedia returns a value of bool, that is true or false, and takes no parameters. So this delegate can hold any method that returns bool and takes no parameters.

        //Step 2: Create a method to use the delegate
        //The next thing we might do is to create a method that uses that delegate. So here we've created the method TestResult. We're passing in an instance of our delegate, see that it says TestMedia, and we're calling that local parameter mediaDelegate.
        public void TestResult(TestMedia MediaDelegate)
        {
            //remember, our delegate holds a method that returns a Boolean. We can invoke that method through the delegate, so you see mediaDelegate has the parens'()' of invoking a method, 
            //and if it's true, if the value we get back is true, then we're going to write to the console that the media worked fine. Otherwise, we're going to write that it's unable to play the media
            if (MediaDelegate() == true) //check if delgate (TestMedia instance MediaDelegate) returns true
            {
                Console.WriteLine("Media works fine, Add to inventory");
            }
            else
            {
                Console.WriteLine("Unable to play Media. Rejected!");
            }
        }

        //Step 3: Create a method that matches the delegate's Return value and parameters (PlayRecord method in RecordPlayer class)
        //In our third step we're going to create a method that matches the delegate. So here we have PlayRecord. That, in fact, takes no parameters, and returns a bool. 
        //And that could do any number of things. We'll have it stand in with a Console. Writeline, and we'll set the status to true, although of course normally that would be dynamic.
        //Notice that PlayRecord nowhere says delegate or the name of the delegate. This is just a method that matches,
        //public bool PlayRecord()
        //{
        //    Console.WriteLine("Testing the record. It works fine");
        //    return true;
        //}

        //Step 3a: Create another method that matches the delgate's return value and parametrs
        // we can create a second method, TestCassette, that also matches the delegate, returns a bool, takes no parameters.
        //public bool TestCassatte()
        //{
        //    Console.WriteLine("Testing cassattes... Failed!");
        //    return false;
        //}

        //Step 4: Instancsiate the delegate (TestDelegate in Worker class)
        //In step 4, we're going to go ahead and instantiate the delegate, notice the keyword new, then the delegate name, TestMedia, and we're going to pass into it a method that meets its signature, that is that has no parameters and meets its returns value, that is returns bool. 

        //Step 5: Invoke the method through the Delegate
        //Finally, in step 5 we're going to invoke that method through the delegate. So when we say TestResult, we're going to pass in our instance of the delegate, and because that instance of the delegate is holding our PlayRecord method, it's going to play it.

    }
}

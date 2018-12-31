using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
           var listOfInt= new List<int> { 2,4,5,7,9,12,15,18};

            var smallerNumbers = from num in listOfInt
                                where num < 8
                                select num;

            foreach(int number in smallerNumbers)
            {
                Console.WriteLine($"Value = {number}");
            }

            Console.WriteLine("\n------------------------------------\n");
            //using Query Operators
            var smallerNumbers2 = listOfInt.Where(n => n < 8).Select(n => n);
            foreach (int number2 in smallerNumbers)
            {
                Console.WriteLine($"Value2 = {number2}");
            }

            //using Query Methods
            ///we're going to examine the methods that are available in the integer type. So we're going to say from method in typeof(int). 
            ///GetMethods. GetMethods is a method that is available for any type, so here we're asking for the methods of the integer type. 
            ///And then we're going to use an orderby clause. We're going to order this by the method. Name. And more interestingly we're going to group. 
            ///So we're going to group the method by method. Name, and we're going to put that into a group called groups. Now we can select, and we're going to create a 
            ///new unnamed class, and it's going to have a member MethodName, which will be set to the groups. Key. And we'll have a member MethodOverloads, 
            ///which will give us the count by simply asking for the count from the groups. So you can see that we can create a relatively complex selection, 
            ///where we're ordering it and grouping it, and then creating essentially a new class, an unnamed class, that has a couple members. Let's iterate through 
            ///that collection, and write each item to the console. And here we see that it has found each method of the integer class, and it has indicated how many 
            ///overloads there are for each method.
            var methods = from method in typeof(int).GetMethods()
                          orderby method.Name
                          group method by method.Name into groups
                          select new
                          {
                              MethodName = groups.Key,
                              MethodOverloads = groups.Count()
                          };

            foreach(var item in methods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------------------------\n");

            #region Deffered Execution 
            ///A very important feature of LINQ is what is referred to as deferred execution. Deferred execution means that LINQ statements are not interpreted until 
            ///they are needed, and to see this we can create an experiment. Enumerable has a Range method. We give it the lowest value we want and the highest, 
            ///and in this case we'll tell it that we want one million. Now one million times we're going to select, passing in the parameter x, and returning the value 
            ///that's between these braces. We're going to use the Thread class, which we have not needed before, to call its Sleep method, so that the application will 
            ///sleep for 500 milliseconds, that is half a second. And then it will return x*x, so that is x squared. Now if this entire LINQ statement were run one 
            ///million times, we would have to wait 500, 000 seconds before we would be able to get to the foreach loop. I'll leave it as an exercise for the reader 
            ///how many hours or days 500, 000 seconds is, but we don't want to wait that long. Here we can see that by printing out the numbers, we're getting our 
            ///numbers every half second. The LINQ statement is being evaluated as needed, rather than evaluating all one million in advance.

            var million = Enumerable.Range(0, 1000000)
                .Select(x =>
                {
                    System.Threading.Thread.Sleep(300);
                    return x * x;
                });
            foreach(var number in million)
            {
                Console.Write(number + " ");
            }

            #endregion

            #region Key Operators
            ///LINQ has number of operators
            ///ANY - Returns a Boolean. Test if collection is empty or contains the value
            ///TAKE - Allows you to choose how many values to retrieve.
            ///Distinct - Retrieve only one of each value
            ///Zip - Threads two lists togather
            ///LINQ has a number of operators for querying and for narrowing the results of a query. We're going to take a look at four operators, Any, which returns true if a collection has any values at all, Take, which allows you to decide how many values to retrieve, Distinct, which as you might guess, returns only distinct values, and my favorite, Zip, which threads two lists together. Let's take a look at a demo of each of this operators.
            #endregion
            #region ANY operator
            #endregion


            Console.ReadLine();
        }
    }
}

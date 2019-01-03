using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQKeyOperators
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            var listOfInt = new List<int>() { 2, 3, 7, 13, 5, 16, 18, 22 };
            var listOfInt2 = new List<int>();

            bool hasAny = listOfInt.Any(); //returns true if collection has any member
            bool hasAny2 = listOfInt2.Any(); //returns false as collection has no member

            bool has3 = listOfInt.Any(x => x == 3);//returns true/false if 3 is member of listOfInt
            bool has15 = listOfInt.Any(x => x == 15);//returns true/false if 15 is member of listOfInt


            Console.WriteLine("Any .....");
            Console.WriteLine($"ListofInt has any menber? {hasAny}");
            Console.WriteLine($"ListofInt2 has any menber? {hasAny2}");

            Console.WriteLine("Check Any member in.....");
            Console.WriteLine($"ListOfInt has3? {has3}");
            Console.WriteLine($"ListOfInt has15? {has15}");

            Console.WriteLine("\n---------------------------\n");
            #region Take operator
            var take5 = listOfInt.Take(5)
                .Select(x => x * 10);
            Console.WriteLine("Take and process ...");
            foreach(var item in take5)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine("\n-------------------------\n");
            #region Distinct Operator
            var multipleValueList = new List<int>() { 2, 3, 6, 2, 5, 3, 8, 13, 13, 14, 67, 2 };
            var distinctList = multipleValueList.Distinct(); //Get Distinct item
            var outputDistinct = multipleValueList.Distinct() //get Distinct item and do calculation
                .Select(x => x * 9);

            Console.WriteLine("Distinct....");

            foreach(var item in distinctList)
            {
                Console.Write(item + ",");

            }
            Console.WriteLine();
            Console.WriteLine("Distinct item and do calculation ...");
            foreach(var item in outputDistinct)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Zip Operator
            ///Our goal is to associate each of the codes with the appropriate state. Let's create a variable to hold the result, which we'll call codesWithStates. 
            ///And then we begin with our first collection, codes, and call the Zip operator. We pass to the Zip operator our second collection, states, and then we pass 
            ///in the two variables, code and state into a lambda expression, and our lambda expression is going to create a string with the code, a colon, and the state.
            ///So it is going to zip together the code list with the state list, and the lambda expression tells it how to display those. We can now iterate through the 
            ///new collection, and display each of the zipped together pairs. And here we see that the codes have been paired with the state names. 
            ///It's important to recognize that the parameters we passed in to the lambda expression, code and state, have no special meaning. So we can change code, 
            ///for example, to c, or anything else we want, and state we'll change to s, although we could have called it Fred, and all we have to do is change the output
            ///to correspond to those values. When we run that, we get precisely the same output.
            Console.WriteLine("\n----------------------------\n");
            var codes = new List<string>(){ "AL","CA","WA","AK","AZ","AR","CO", "CT" };
            var states = new List<string>()
            { "Alabama", "California", "Washington", "Alaska", "Arizona", "Arkansas", "Colorado", "Connecticut" };

            //map the states with code
            //var codesWithStates = codes.Zip(states, (code, state) => $"{code} : {state}"); //first collection, codes, and call the Zip operator. We pass to the Zip operator our second collection, states, and then we pass 
                                                                                            ///in the two variables, code and state into a lambda expression, and our lambda expression is going to create a string with the code, a colon, and the state.
            var codesWithStates = codes.Zip(states, (c, s) => $"{c}:{s}");

            foreach(var item in codesWithStates)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpOperator.TerNull
{
    class ImportantOperator
    {
        //Three important operator
        // 1. Ternary Operator 2. Null Conditional 3. Null Coalescing
        #region Funda: Ternary Operator
        //int bigger = x > y ? x : y
        //Ternary Operator
        // 1. Shorthand if/else statement
        // Test and return first term if true, second if false
        #endregion

        #region Funda: Null conditional operator
        //Null Conditioal
        //Used with collection and classes
        // The operator is ?. (question mark dot [period])
        //The null conditional operator uses the question mark dot syntax, and what says is, don't crash on a null, instead, if it is null return null, otherwise return the value.
        //Ex. List<string> authors = null;
        //int? count = authors?.Count;
        //string message = count == null ? "count is null" : "count is not null";
        //Console.WriteLine(message);
        #endregion

        #region Funnda : Null Coalescing
        //Null coalescing
        // Operator is written as two question mark (??)
        //if the left hand operand is not null,  return it. Otherwise return the right hand operator.
        //what it says is examine the left hand operand, and if it's not null, go ahead and return it, otherwise, return the right hand operator.
        //Ex. List<string> authors = null;
        //int? howMany = authors?.Count ?? 0; //using both null condition and Null coalescing operator
        //Console.WriteLine("Null coalescing howmany = :" + howMany ); 
        //authors = new List<string>() { "Hello", "world"};
        //howMany = authours?.Count ?? 0
        //Console.WriteLine("Null coalescing howmany = :" + howMany );
        //So null coalescing does not return null, it either returns author?. Count or it returns the value 0.
        #endregion

    }
}

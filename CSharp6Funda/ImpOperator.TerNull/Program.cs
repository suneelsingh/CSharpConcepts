using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpOperator.TerNull
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null operator
            int? x = null;
            Console.WriteLine($"x is null : { x}");

            List<string> authors = null;
            int? count = authors?.Count; //Using null conditional operator. It will return null if count is null otherwise count.
            string message = count == null ? "count is null" : "count is not null"; //using Ternary operator to assign conditional value to message variable.
            Console.WriteLine(message);

            //using null conditional & null coalescing operator
            int howMany = authors?.Count ?? 0; //what it says is examine the left hand operand, and if it's not null, go ahead and return it, otherwise, return the right hand operator.
            //if authors is null or authos.Count is null return 0 otherwise return count
            Console.WriteLine($"homany : {howMany}");

            authors = new List<string>()
            {
                "Salman Khusid",
                "Premchand"
            };

            howMany = authors?.Count ?? 0;
            Console.WriteLine($"howmany : {howMany}");

            Console.ReadLine();

        }
    }
}

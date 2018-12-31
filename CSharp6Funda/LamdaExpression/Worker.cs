using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        #region Funda : Lamda and Delegate
        /// <summary>
        /// In Work we're going to create two local variables, a and b, and assign values to them. And then we're going to create a delegate, 
        /// but we're going to do it slightly differently this time for a little bit of variety. 
        /// We're going to use the keyword func, pass in int three times, and that means that this will be a delegate that will hold a method that takes 
        /// two integer parameters and returns an integer. We're going to call that delegate multiplyDelegate. 
        /// Now we're going to assign multiplyDelegate to a method that matches that two integer parameters and returning an integer, and of course that's our 
        /// Multiply method, and you can see that that does match. And now we're going to call the method that we've attached to that delegate through the delegate, 
        /// so we'll need parens, and pass in two values, a and b. We're going to assign the result of that to product, and then we'll write out the results to the console. 
        /// Now we're going to do it a different way. We'll start out with the func, and the three ints, indicating that this delegate will also hold the method that 
        /// takes two ints and returns one, and we'll call it multiplyDelegate2, but here we're going to assign a lambda expression. 
        /// And you may remember that the two params in the first pair of parentheses are the parameters, and their type is inferred, 
        /// and then the two params at the end is the return value where the keyword return is inferred. So this says that it's going to be a method that takes 
        /// two parameters, x and y, and returns their product. Let's move these down so that there's a little bit more visibility. 
        /// Notice we don't need the Multiply method for this second multiplyDelegate because it's encapsulated in this lambda expression. 
        /// But we can use this just as we used the first one, so let's call through this delegate, effectively calling that lambda expression and passing in a and b as 
        /// the parameters, getting back an integer which we're assigning to product2, and let's display that result to the console. So you can see that these 
        /// two delegates look quite different, and are designed quite differently, but they accomplish the same thing.
        /// Explaination:
        /// here you can see that the first of the two delegates is going to hold two integer parameters and return an integer. 
        /// That is, it's going to hold a method that takes two integer parameters and returns an integer. And we're assigning that delegate to the method Multiply that,
        /// in fact, does take two integer parameters and returns an int, and then we're calling Multiply through the delegate, passing in the values of a and b. 
        /// In the second case, we are instantiating multiplyDelegate2, which we're saying is a delegate that holds a method that takes two ints and returns an int, 
        /// but we're assigning to that the lambda expression, where x and y are the two parameters, and the return value is x*y. We then call multilpyDelegate2, 
        /// which passes to that lambda expression the values of a and b. The net result is they both return the same value.
        /// </summary>
        #endregion
        public void Work()
        {
            int a = 10;
            int b = 20;
            //int result = Multiply(4, 5);
            //Console.WriteLine($"4 x 5 = {result}");

            //using delegate in a new way i.e. by using Func <>
            ///the keyword func, pass in int three times, and that means that this will be a delegate that will hold a method that takes 
            /// two integer parameters and returns an integer. We're going to call that delegate multiplyDelegate. 
            /// Now we're going to assign multiplyDelegate to a method that matches that two integer parameters and returning an integer, and of course that's our 
            /// Multiply method, and you can see that that does match. And now we're going to call the method that we've attached to that delegate through the delegate, 
            /// so we'll need parens, and pass in two values, a and b. We're going to assign the result of that to product, and then we'll write out the results to the console.
            Func<int, int, int> multiplyDelegate;
            multiplyDelegate = Multiply; //assign delegate to a method that matches the delgate signature i.e. Multiply
            int product = multiplyDelegate(a, b); //call the method, which is attached to the delegate, through the delegate
            Console.WriteLine($"Product = {product}");

            //through Lamda
            ///We'll start out with the func, and the three ints, indicating that this delegate will also hold the method that 
            /// takes two ints and returns one, and we'll call it multiplyDelegate2, but here we're going to assign a lambda expression. 
            /// And you may remember that the two params in the first pair of parentheses are the parameters, and their type is inferred, 
            /// and then the two params at the end is the return value where the keyword return is inferred. So this says that it's going to be a method that takes 
            /// two parameters, x and y, and returns their product. Let's move these down so that there's a little bit more visibility. 
            /// Notice we don't need the Multiply method for this second multiplyDelegate because it's encapsulated in this lambda expression.
            Func<int, int, int> multiplyDelegate2 = (x, y) => (x * y);
            //multiplyDelegate2 = Multiply; //not needed
            int product2 = multiplyDelegate2(a, b); //call the method, which is attached to the delegate, through the delegate
            Console.WriteLine($"Product2 = {product}");

            Console.ReadLine();




        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}

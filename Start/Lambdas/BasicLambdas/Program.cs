using System;

namespace BasicLambdas
{
    // define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExprDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a basic delegate that squares a number
            MyDelegate d1 = (x) => x * x;
            Console.WriteLine("d1 : " + d1(5));
            // TODO: Dynamically change the delegate to something else
            d1 = (x) => x * 10;
            Console.WriteLine("changed d1 :" +d1(5));
            // TODO: Create a delegate that takes multiple arguments
            MyDelegate2 d2 = (x, y) =>
            {
                Console.WriteLine("The 2 arg lamda: " + x + " " + y);
            };
            d2(25, "Hello");
            // TODO: Define an expression delegate
            ExprDelegate e = x => x > 10;

            Console.WriteLine("Expr 9 {0}", e(9));
            Console.WriteLine("Expr 19 {0}", e(19));
        }
    }
}
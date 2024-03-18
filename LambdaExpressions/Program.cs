using System;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers to be evaluated.");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());  

            //add
            var sum = (int x, int y) => x + y;
            //multipy
            var product = (int x, int y) => x * y;

            //smaller
            var smallerValue = (int x, int y) =>
            {
                if (x < y)
                    return x;
                else
                    return y;
            };

                Console.WriteLine($"The sum is: {sum(x,y)}");
                Console.WriteLine($"The product is: {product(x,y)}");
                Console.WriteLine($"The smallerr value is: {smallerValue(x,y)}");
                Console.WriteLine();

        }
    }
}
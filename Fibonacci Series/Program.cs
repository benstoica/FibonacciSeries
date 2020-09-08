using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        public static int FibonacciNumber(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else 
            {
                return (FibonacciNumber(n - 1) + FibonacciNumber(n - 2));
            }

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Which number in the Fibonacci Sequence would you like to know?");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"The number in position {number} in the Fibonacci Sequence is ");
            number = number - 1;
            Console.Write(FibonacciNumber(number));
            Console.ReadKey();
            
        }
    }
}

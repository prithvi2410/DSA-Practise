using System;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(3));
        }
        static int fib(int n)
        {
            if(n<2)
                return n;
            
            return fib(n-1) + fib(n-2);
        }
    }
}
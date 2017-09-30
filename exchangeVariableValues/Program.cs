using System;

namespace exchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");

           int hold = a;
            a = b;
            b = hold;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}

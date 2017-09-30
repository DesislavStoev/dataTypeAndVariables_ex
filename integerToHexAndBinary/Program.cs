using System;

namespace integerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           string hex = num.ToString("X");
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}

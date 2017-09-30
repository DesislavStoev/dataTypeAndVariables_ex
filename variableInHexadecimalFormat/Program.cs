using System;

namespace variableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(n, 16));
        }
    }
}

using System;

namespace booleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool str1 =  Convert.ToBoolean(str);
            if (str1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

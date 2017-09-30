using System;

namespace stringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object concat = str1 + " " + str2;
            string str3 = (string)concat;
            Console.WriteLine(str3);
        }
    }
}

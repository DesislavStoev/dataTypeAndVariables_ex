using System;

namespace vowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            char[] vowel = new char []{ 'a', 'o', 'u', 'i', 'e' , 'y', 'A', 'O', 'U', 'I', 'E', 'Y' };
            foreach (var item in vowel)
            {
                if (item == symbol)
                {
                    Console.WriteLine("vowel");
                    return;
                }
            }
            if (symbol >= 48 && symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

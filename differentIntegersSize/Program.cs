using System;

namespace differentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool sb = false;
            bool b = false;
            bool s = false;
            bool us = false;
            bool i = false;
            bool ui = false;
            bool l = false;

            try
            {
                sbyte num1 = sbyte.Parse(num);
                sb = true;
            }
            catch (Exception)
            {  
            }
            try
            {
                byte num2 = byte.Parse(num);
                b = true;
            }
            catch (Exception)
            {
            }
            try
            {
                short num3 = short.Parse(num);
                s = true;
            }
            catch (Exception)
            {
            }
            try
            {
                ushort num4 = ushort.Parse(num);
                us = true;
            }
            catch (Exception)
            {
            }
            try
            {
                int num5 = int.Parse(num);
                i = true;
            }
            catch (Exception)
            {
            }
            try
            {
                uint num6 = uint.Parse(num);
                ui = true;
            }
            catch (Exception)
            {
            }
            try
            {
                long num7 = long.Parse(num);
                l = true;
            }
            catch (Exception)
            {
            }

            if (sb || b || s || us || i || ui || l)
            {
                Console.WriteLine($"{num} can fit in:");
                if (sb)
                {
                    Console.WriteLine("* sbyte");
                }
                if (b)
                {
                    Console.WriteLine("* byte");
                }
                if (s)
                {
                    Console.WriteLine("* short");
                }
                if (us)
                {
                    Console.WriteLine("* ushort");
                }
                if (i)
                {
                    Console.WriteLine("* int");
                }
                if (ui)
                {
                    Console.WriteLine("* uint");
                }
                if (l)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine(num + " can't fit in any type");
              
            }
        }
    }
}

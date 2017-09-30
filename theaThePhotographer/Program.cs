using System;
using System.Numerics;

namespace theaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long ft = long.Parse(Console.ReadLine());
            long ff = long.Parse(Console.ReadLine());
            long ut = long.Parse(Console.ReadLine());

            BigInteger filterTime = n * ft;
            long filterFactor = (long)Math.Ceiling((n * (double) ff) / 100);
            BigInteger uploadTime = (long)filterFactor * ut;

            BigInteger totalTime = filterTime + uploadTime;
            BigInteger days = totalTime / (3600 * 24);
            BigInteger hours = (totalTime % (3600 * 24)) / 3600;
            BigInteger minutes = ((totalTime % (3600 * 24)) % 3600) / 60;
            BigInteger second = ((totalTime % (3600 * 24)) % 3600) % 60;

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{second:d2}");
        }
    }
}

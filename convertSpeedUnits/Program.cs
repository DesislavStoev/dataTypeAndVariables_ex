using System;

namespace convertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes = int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());

            int mile = 1609;  
            float meterPerSec = distance / (hours * 3600 + minutes * 60 + seconds);
            float kmPerHour = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            float milePerHour = (distance / mile) / (hours + minutes / 60 + seconds / 3600);

            Console.WriteLine("{0}",meterPerSec);
            Console.WriteLine("{0}",kmPerHour);
            Console.WriteLine("{0}",milePerHour);
        }
    }
}

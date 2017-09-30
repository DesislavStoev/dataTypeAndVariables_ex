using System;

namespace employeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {secondName}\nAge: {age}" +
                $"\nGender: {gender}\nPersonal ID: {personalID}\nUnique Employee number: {uniqueEmployeeNumber}");
        }
    }
}

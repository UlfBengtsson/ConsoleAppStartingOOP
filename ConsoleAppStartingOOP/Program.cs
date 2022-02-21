using ConsoleAppStartingOOP.Model;
using System;

namespace ConsoleAppStartingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Ulf";
            person.LastName = "Bengtsson";

            //Console.WriteLine(person);
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}

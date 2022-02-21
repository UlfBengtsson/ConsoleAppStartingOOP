using ConsoleAppStartingOOP.Model;
using System;
using System.Collections.Generic;

namespace ConsoleAppStartingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OnePerson();
            ListOfPeople();
        }

        static void OnePerson()
        {
            Console.WriteLine("People count: " + Person.PersonsCreated);

            Person person = new Person("Ulf", "Bengttson");

            Console.WriteLine("People count: " + Person.PersonsCreated);

            //person.FirstName = "Ulf";
            //person.LastName = "Bengtsson";

            //Console.WriteLine(person);
            //Console.WriteLine($"{person.FirstName} {person.LastName}");
            //Console.WriteLine(person.FullName);

            Console.WriteLine(person.IntroduceYourself());
        }

        static void ListOfPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Kent", "Svensson"));
            people.Add(new Person("Ola", "Andersson"));
            people.Add(new Person("Sandra", "Larsson"));

            foreach (Person listItem in people)
            {
                Console.WriteLine(listItem.IntroduceYourself());
            }

        }
    }
}

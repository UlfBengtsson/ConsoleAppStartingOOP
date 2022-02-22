using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStartingOOP.Model
{
    public class Person
    {
        //defualt access to methods/fields is private
        static int idCounter = 0;
        public static int PersonsCreated { get { return idCounter; } }

        int id;//fields are default set to 0
        public int Id { get { return id; } }

        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("First name must contain at least 2 letters.");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("First name must contain at least 2 letters.");
                }
                lastName = value;
            }
        }

        public string FullName { get { return $"{firstName} {lastName}"; } }

        //by defualt, if i dont make a cunstructor, C# will make one

        public Person(string firstName, string lastName)
        {
            id = ++idCounter;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string IntroduceYourself()
        {
            return $"Hello my name is {FullName} and work ID is: {id}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStartingOOP.Model
{
    internal class Person
    {
        //defualt access to methods/fields is private

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


        //by defualt, if i dont make a cunstructor, C# will make one
    }
}

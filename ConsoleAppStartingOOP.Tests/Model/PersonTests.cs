using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleAppStartingOOP.Model;

namespace ConsoleAppStartingOOP.Tests.Model
{
    public class PersonTests
    {
        //[Fact]
        //public void Test1()
        //{
                //Arrange

                //Act

                //Assert
        //}

        [Fact]
        public void PersonCunstructorTest()
        {
            //Arrange
            string firstName = "tessa";
            string lastName = "testsson";

            //Act
            Person result = new Person(firstName, lastName);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(firstName, result.FirstName);
            Assert.Equal(lastName, result.LastName);
            Assert.NotEqual(0, result.Id);
        }

        [Fact]
        public void IdGenerationIsUniqueTest()
        {
            //Arrange
            Person person1 = new Person("person1", "last1");
            Person person2 = new Person("person2", "last2");
            Person person3 = new Person("person3", "last3");

            //Act

            //Assert
            Assert.NotEqual(person1.Id, person2.Id);
            Assert.NotEqual(person1.Id, person3.Id);
            Assert.NotEqual(person2.Id, person3.Id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        public void BadFirstNameConstructorTest(string firstName)
        {
            //Arrange
            string lastName = "svensson";

            //Act
            Assert.Throws<ArgumentException>(() => new Person(firstName, lastName));

            //Assert
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        public void BadFirstNamePropertyTest(string badFirstName)
        {
            //Arrange
            string lastName = "svensson";
            Person person = new Person("safeFirstName", lastName);

            //Act
            Assert.Throws<ArgumentException>(() => person.FirstName = badFirstName);

            //Assert
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        public void BadLastNameConstructorTest(string lastName)
        {
            //Arrange
            string firstName = "sven";

            //Act
            Assert.Throws<ArgumentException>(() => new Person(firstName, lastName));

            //Assert
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        public void BadLastNamePropertyTest(string badLastName)
        {
            //Arrange
            string firstName = "ola";
            Person person = new Person(firstName, "Larsson");

            //Act
            Assert.Throws<ArgumentException>(() => person.LastName = badLastName);

            //Assert
        }
    }
}

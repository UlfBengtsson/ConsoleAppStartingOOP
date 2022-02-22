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
        //    //Arrange

        //    //Act

        //    //Assert
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
        }
    }
}

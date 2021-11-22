using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Classes;

namespace TDD.Tests.Classes
{
    [TestFixture]
    public class GreeterTests
    {
        private Greeter? _greeter;

        [SetUp]
        public void SetUp()
        {
            _greeter = new Greeter();
        }

        [Test]
        public void GreetPerson_GivenEmptyString_ReturnsHejKompis()
        {
            // Arrange
            string indata = "";
            string expectedResult = "Hej Kompis";

            // Act
            string calculatedResult = _greeter!.GreetPerson(indata);

            // Assert
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GreetPerson_GivenNull_ReturnsHejKompis()
        {
            // Arrange
            string indata = null;
            string expectedResult = "Hej Kompis";

            // Act
            string calculatedResult = _greeter!.GreetPerson(indata);

            // Assert
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GreetPerson_GivenName_ReturnsHejName()
        {
            // Arrange
            string indata = "Dan";
            string expectedResult = "Hej Dan";

            // Act
            string calculatedResult = _greeter!.GreetPerson(indata);

            // Assert
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GreetPerson_NameInUPPERCASE_ReturnsHEJNAME()
        {
            // Arrange
            string indata = "DAN";
            string expectedResult = "HEJ DAN!";

            // Act
            string calculatedResult = _greeter!.GreetPerson(indata);

            // Assert
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

    }
}

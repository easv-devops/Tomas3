using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
           
        {
            // Arrange
            var number1 = 3.6;
            var number2 = 5.6;
            var expected = 9.2;

            // Act
            CalClass calClass = new CalClass();
            var result = calClass.Calculate(number1, number2); // Assuming Calculate is public and in Program class

            // Assert
            Assert.AreEqual(expected, result, "The Calculate method did not add two numbers correctly.");
        }

    }
}
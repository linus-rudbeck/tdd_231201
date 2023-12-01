using Moq;
using NUnit.Framework;
using tdd_231201.Utilities;


namespace tdd_231201.Tests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var expected = 5;
            var actual = calc.Add(2,3);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_ReturnsCorrectResult()
        {
            var result = Calculator.GetArray(3, 3);

            Assert.That(result, Has.Exactly(3).EqualTo(3));
        }

        [Test]
        public void TestMockIcalc()
        {
            // Arrange
            var calculatorMock = new Mock<ICalculator>();
            calculatorMock.Setup(m => m.Add(
              It.IsAny<int>(), //Any value
              It.IsAny<int>()  //Any value
            )).Returns(10);

            // Act
            var result = calculatorMock.Object.Add(1,2);

            // Assert
            calculatorMock.VerifyAll();
            Assert.That(result, Is.EqualTo(10));
        }
    }
}

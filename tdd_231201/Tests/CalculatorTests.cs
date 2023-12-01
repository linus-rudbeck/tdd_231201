using NUnit.Framework;
using tdd_231201.Classes;


namespace tdd_231201.Tests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            var expected = 5;
            var actual = Calculator.Add(2,3);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_ReturnsCorrectResult()
        {
            var result = Calculator.GetArray(3, 3);

            Assert.That(result, Has.Exactly(3).EqualTo(3));
        }
    }
}

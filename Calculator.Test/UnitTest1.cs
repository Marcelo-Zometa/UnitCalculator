using NUnit.Framework;

namespace Calculator.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        
        [TestCase(12.7, 5, "TO CM")]
        [TestCase(-0.0000508, -2, "TO kM")]
        [TestCase(15, 15, "TO in")]
        [Test]
        public void TestInches(double expected, double given, string text)
        {
            Inch inch = new Inch();
            inch.setToUnit(text);

            Assert.AreEqual(expected, inch.Calculate(given));
        }

        [Test]
        public void TestInvalidInput()
        {
            Inch inch = new Inch();

            Assert.AreEqual(0, inch.Calculate(2));
        }
    }
}
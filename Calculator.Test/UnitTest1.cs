using NUnit.Framework;

namespace Calculator.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Inch inch = new Inch();
            inch.setToUnit("To cm");

            Assert.AreEqual(12.7, inch.Calculate(5));
        }
    }
}
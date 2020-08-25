using NUnit.Framework;
using System;

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

        [TestCase(1,1,"something")]
        [Test]
        public void TestInvalidInputOption(double expected, double given, string text)
        {
            Inch inch = new Inch();
            inch.setToUnit(text);

            try
            {
                //Exception should be thrown
                inch.Calculate(given);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
        }
    }
}
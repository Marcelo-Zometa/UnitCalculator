using NUnit.Framework;
using System;

namespace Calculator.Test
{
    public class Tests
    {        
        [TestCase(12.7, 5, "TO CM")]
        [TestCase(-0.0000508, -2, "TO kM")]
        [TestCase(15, 15, "TO in")]
        [Test]
        public void TestInches(double expected, double given, string text)
        {
            Inch inch = new Inch();
            
            Assert.AreEqual(expected, inch.Calculate(given, text));
        }

        [TestCase(152.4, 5, "TO CM")]
        [TestCase(-0.0006096, -2, "TO kM")]
        [TestCase(180, 15, "TO in")]
        [Test]
        public void TestFeet(double expected, double given, string text)
        {
            Foot foot= new Foot();
 
            Assert.AreEqual(expected, foot.Calculate(given, text));
        }

        [TestCase(804_672, 5, "TO CM")]
        [TestCase(-8.04672, -5, "TO kM")]
        [TestCase(316_800, 5, "TO in")]
        [Test]
        public void TestMile(double expected, double given, string text)
        {
            Mile mile= new Mile();

            Assert.AreEqual(expected, mile.Calculate(given, text));
        }

        [TestCase(5, 5, "TO CM")]
        [TestCase(-0.00005, -5, "TO kM")]
        [TestCase(1.9685039500000001, 5, "TO in")]
        [Test]
        public void TestCm(double expected, double given, string text)
        {
            Centimeter centimeter= new Centimeter();

            Assert.AreEqual(expected, centimeter.Calculate(given, text));
        }

        [TestCase(500, 5, "TO CM")]
        [TestCase(-0.005, -5, "TO kM")]
        [TestCase(196.8503935, 5, "TO in")]
        [Test]
        public void TestM(double expected, double given, string text)
        {
            Meter meter= new Meter();

            Assert.AreEqual(expected, meter.Calculate(given, text));
        }

        [TestCase(500_000, 5, "TO CM")]
        [TestCase(-5, -5, "TO kM")]
        [TestCase(196850.39350000001, 5, "TO in")]
        [Test]
        public void TestKm(double expected, double given, string text)
        {
            Kilometer kilometer= new Kilometer();

            Assert.AreEqual(expected, kilometer.Calculate(given, text));
        }

        [TestCase(1,1,"something")]
        [Test]
        public void TestInvalidInputOption(double expected, double given, string text)
        {
            Inch inch = new Inch();

            try
            {
                //Exception should be thrown
                inch.Calculate(given, text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Pass();
            }
        }
    }
}
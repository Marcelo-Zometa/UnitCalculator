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
            Class1 c = new Class1();
            Assert.AreEqual(2, c.Add(1, 1));
        }
    }
}
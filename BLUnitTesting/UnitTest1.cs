using NUnit.Framework;

namespace BLUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase()]
        public void Test1(string[,] field)
        {
            Assert.Pass();
        }
    }
}
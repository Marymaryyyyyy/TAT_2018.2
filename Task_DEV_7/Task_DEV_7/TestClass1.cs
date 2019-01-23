using NUnit.Framework;
using Task_DEV_7;

namespace nUnitTask_DEV_7.Tests1
{
    [TestFixture]
    public class TestConvertor
    {
        [TestCase(16, 28, "1C")]
        [TestCase(2, 8, "1000")]
        [TestCase(15, 15, "10")]
        [TestCase(10, 0, "0")]
        [Test]
        public void ValidBaseValidValueTest(int convertedToValue, int inputNumber, string result)
        {
            NumeralSystemsConvertor convertor = new NumeralSystemsConvertor();
            Assert.AreEqual(result, convertor.ConvertTo(inputNumber, convertedToValue));
        }
    }
}

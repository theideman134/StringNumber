using NUnit.Framework;
using StringVersionNumber.Controllers;

namespace StringVersionNumberTest
{
    public class StringtoDecimalTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OneTest()
        {
            var controller = new StringToDecimalController();
            int value = controller.StringtoInt("one");
            Assert.AreEqual(1, value);

        }

        [Test]
        public void TwoTest()
        {
            var controller = new StringToDecimalController();
            int value = controller.StringtoInt("two");
            Assert.AreEqual(2, value);

        }

        [Test]
        public void ElevenTest()
        {
            var controller = new StringToDecimalController();
            int value = controller.StringtoInt("eleven");
            Assert.AreEqual(11, value);

        }
        [Test]
        public void OneHundred12Test()
        {
            var controller = new StringToDecimalController();
            int value = controller.HundredStringtoInt("one hundred twelve");
            Assert.AreEqual(112, value);

        }

        [Test]
        public void FiveHundred32Test()
        {
            var controller = new StringToDecimalController();
            int value = controller.HundredStringtoInt("five hundred thirty-two");
            Assert.AreEqual(532, value);

        }
    }
}

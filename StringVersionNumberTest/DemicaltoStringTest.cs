using NUnit.Framework;
using StringVersionNumber.Controllers;

namespace StringVersionNumberTest
{
    public class DemicaltoStringTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TooHighTest()
        {
            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(1000M);
            Assert.AreEqual(string.Empty, value);

        }
        [Test]
        public void TooSmallTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(-1M);
            Assert.AreEqual(string.Empty, value);
        }
        [Test]
        public void nineninenineTest()
        {
            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(999M);
            Assert.AreEqual("nine hundred ninety nine", value);
        }
        [Test]
        public void oneTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(1M);
            Assert.AreEqual("one", value);
        }

        [Test]
        public void oneandoneTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(101M);
            Assert.AreEqual("one hundred one", value);
        }
        [Test]
        public void FiftyTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(50M);
            Assert.AreEqual("fifty", value);
        }
        [Test]
        public void FiftyFiveTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(55M);
            Assert.AreEqual("fifty five", value);
        }
    }
}
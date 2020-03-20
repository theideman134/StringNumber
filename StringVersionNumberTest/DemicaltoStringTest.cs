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
            Assert.AreEqual("nine hundred ninety-nine", value.Trim());
        }
        [Test]
        public void oneTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(1M);
            Assert.AreEqual("one", value.Trim());
        }

        [Test]
        public void oneandoneTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(101M);
            Assert.AreEqual("one hundred one", value.Trim());
        }
        [Test]
        public void FiftyTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(50M);
            Assert.AreEqual("fifty", value.Trim());
        }
        [Test]
        public void FiftyFiveTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.HundredsString(55M);
            Assert.AreEqual("fifty-five", value.Trim());
        }

        [Test]
        public void OneThousandTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("1000");
            Assert.AreEqual("one thousand", value);
        }

        [Test]
        public void OneThousand888Test()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("1888");
            Assert.AreEqual("one thousand eight hundred eighty-eight", value);
        }

        [Test]
        public void Onehundred19Thousand223Test()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("119223");
            Assert.AreEqual("one hundred nineteen thousand two hundred twenty-three", value);
        }

        [Test]
        public void TwelveMillionTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("12000000");
            Assert.AreEqual("twelve million", value);
        }

        [Test]
        public void fourteenbillionTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("14000000000");
            Assert.AreEqual("fourteen billion", value);
        }

        [Test]
        public void thirteenbillion232Test()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("13232000000");
            Assert.AreEqual("thirteen billion two hundred thirty-two million", value);
        }

        [Test]
        public void eightteentrillionTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("18000000000000");
            Assert.AreEqual("eighteen trillion", value);
        }


        [Test]
        public void ZeroTest()
        {

            DecimalToStringController controller = new DecimalToStringController();
            string value = controller.Get("0");
            Assert.AreEqual("zero", value);
        }
        [Test]
        public void TrillionTest()
        {
            var stringToDecimalController = new StringToDecimalController();

            stringToDecimalController.Get("one trillion");


        }

    }
}
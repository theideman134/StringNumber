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

        [Test]
        public void   ThousandTest()
        {
            var controller = new StringToDecimalController();
            long value  = controller.Get("one thousand");
            Assert.AreEqual(1000, value);

        }

        [Test]
        public void MillionThousandTest()
        {
            var controller = new StringToDecimalController();
            long value = controller.Get("one million one thousand one");
            Assert.AreEqual(1001001, value);

        }

        [Test]
        public void BillionTest()
        {
            var controller = new StringToDecimalController();
            long value = controller.Get("one billion");
            Assert.AreEqual(1000000000, value);

        }

        [Test]
        public void Billion2Test()
        {
            var controller = new StringToDecimalController();
            long value = controller.Get("one billion five thousand");
            Assert.AreEqual(1000005000, value);

        }

        [Test]
        public void onetrillionTest()
        {
            var controller = new StringToDecimalController();
            long value = controller.Get("one trillion");
            Assert.AreEqual(1000000000000, value);

        }

        [Test]
        public void onetrillionbigTest()
        {
            var controller = new StringToDecimalController();
            long value = controller.Get("one hundred twenty-five trillion five hundred seventy-two billion two hundred sixty-one million");
            Assert.AreEqual(125572261000000, value);

        }

        [Test]
        public void CalculatetrillionTest()
        {
            var controller = new StringToDecimalController();
            int[] intArray = new int[6];
            intArray[0] = 125;
            long value = controller.CalculateNumber(intArray);
            Assert.AreEqual(125000000000000, value);

        }

        [Test]
        public void CalculateBillionTest()
        {
            var controller = new StringToDecimalController();
            int[] intArray = new int[6];
            intArray[1] = 234;
            long value = controller.CalculateNumber(intArray);
            Assert.AreEqual(234000000000, value);

        }

        [Test]
        public void CalculateMillionTest()
        {
            var controller = new StringToDecimalController();
            int[] intArray = new int[6];
            intArray[2] = 345;
            long value = controller.CalculateNumber(intArray);
            Assert.AreEqual(345000000, value);

        }
        [Test]
        public void CalculateThousandTest()
        {
            var controller = new StringToDecimalController();
            int[] intArray = new int[6];
            intArray[3] = 678;
            long value = controller.CalculateNumber(intArray);
            Assert.AreEqual(678000, value);

        }

        [Test]
        public void CalculateHundredTest()
        {
            var controller = new StringToDecimalController();
            int[] intArray = new int[6];
            intArray[4] = 879;
            long value = controller.CalculateNumber(intArray);
            Assert.AreEqual(879, value);

        }
    }
}

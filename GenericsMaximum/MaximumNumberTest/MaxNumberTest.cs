using GenericsMaximum;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        public void GivenIntegerValue_ReturnMaximum()
        {
            MaximumNumber maximum = new MaximumNumber();
            int data = maximum.MaxNumber(15, 20, 30);
            Assert.AreEqual(30, data);
        }
    }
}
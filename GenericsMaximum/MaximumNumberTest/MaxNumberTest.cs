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
            double data = maximum.MaxNumber(15.5, 20.2, 30.3);
            Assert.AreEqual(30.3, data);
        }
    }
}
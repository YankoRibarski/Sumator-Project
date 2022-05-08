using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });
            Assert.That(result == 12);
        }
        [Test]
        public void Test_Sum_One_Number()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.That(result == 5);
        }
    }
}
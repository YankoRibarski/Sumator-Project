using NUnit.Framework;

namespace Summator
{
    public class Tests
    {

        [Test]
        public void testSumTwoPossitiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5, 5 });


            Assert.That(result == 10);
        }
        [Test]
        public void testSumTwoOneNumber()
        {
            long result = Summator.Sum(new int[] { 5 });


            Assert.That(result == 5);
        }

        [Test]
        public void testSumTwoNegativeNumbers()
        {
            long result = Summator.Sum(new int[] { -5, -5 });


            Assert.That(result == -10);
        }
        [Test]
        public void testSumEmptyArray()
        {
            long result = Summator.Sum(new int[] { });


            Assert.That(result == 0);
        }

        [Test]
        public void testSumBigValues()
        {
            long result = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });


            Assert.That(result == 6000000000);
        }
        [Test]
        public void Test_Avarege_Sum()
        {
            double result = Summator.Avarege(new double[] { 5,6 });


            Assert.That(result == 5.5);
        }
        [Test]
        public void Test_Add_number()
        {
            double actualresult = Summator.AddNumber(18, 14);
            double expextedresult = 32;


            Assert.That((double)actualresult, Is.EqualTo(expextedresult));

        }
        [Test]
        public void Test_Even_Sum()
        {
            int result = Summator.SumEvenNumbers(new int[] { 1, 2, 3, 4, 5, 6, });
            int expected = 12;

            Assert.That(result == expected);

        }



    }
}
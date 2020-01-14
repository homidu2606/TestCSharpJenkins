using NUnit.Framework;
using TestCSharpJenkins;

namespace Tests
{
    public class Tests
    {
        private Comparision comparision;
        int a, b, b1;

        [SetUp]
        public void Setup()
        {
            comparision = new Comparision();
            a = 10;
            b = 5;
            b1 = 5;
        }

        [Test]
        public void GreaterThanTest()
        {
            // arrange
            
            string message = string.Format("The number {0} is not greater than {1}", a, b);

            // act
            bool result = comparision.GreaterThan(a, b);

            // assert
            Assert.IsTrue(result, message);
        }

        [Test]
        public void LessThanTest()
        {
            // arrange

            string message = string.Format("The number {0} is not less than {1}", b, a);

            // act
            bool result = comparision.LessThan(b, a);

            // assert
            Assert.IsTrue(result, message);
        }

        [Test]
        public void EqualTest()
        {
            // arrange

            string message = string.Format("The number {0} is not equal {1}", b, b1);

            // act
            bool result = comparision.Equal(b, b1);

            // assert
            Assert.IsTrue(result, message);
        }
    }
}
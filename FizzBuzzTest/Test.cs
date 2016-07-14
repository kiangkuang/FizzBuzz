using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class Test
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(1, "1")]
        [TestCase(-3, "Fizz")]
        [TestCase(0, "FizzBuzz")]
        public void TestFizzBuzz(int input, string expected)
        {
            Assert.AreEqual(expected, Program.GetResult(input));
        }
    }
}

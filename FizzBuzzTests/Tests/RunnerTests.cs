using System;
using System.Linq;
using FizzBuzz;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RunnerTests
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(25, "Buzz")]
        [TestCase(31, "31")]
        public void For_a_given_number_expect_a_string_result(int value, string expectedResult)
        {
            var runner = GetRunner();
            var result = runner.GetLine(value);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Given_start_value_less_than_end_value()
        {
            var runner = GetRunner();

            var result = runner.Run(2, 6).ToArray();

            CollectionAssert.AreEqual(new[]{"2", "Fizz", "4", "Buzz", "Fizz"}, result);
        }

        [Test]
        public void Given_start_value_is_greater_than_end_value()
        {
            var runner = GetRunner();

            var result = runner.Run(100, 10).ToArray();

            Assert.IsEmpty(result);
        }

        private Runner GetRunner()
        {
            return new Runner();
        }
    }
}

using System;
using System.Collections.Generic;
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

        [Test]
        public void A_Runner_with_no_ReplacementSettings_should_return_values_as_strings()
        {
            var runner = new Runner(new TestRunnerSetting(null));
            var result = runner.Run(2, 4);
            CollectionAssert.AreEqual(new[] {"2", "3", "4"}, result);
        }

        private Runner GetRunner()
        {
            return new Runner(new DefaultRunnerSettings());
        }

        class TestRunnerSetting : IRunnerSettings
        {
            private readonly IDictionary<int, string> replacements;

            public TestRunnerSetting(IDictionary<int, string> replacements)
            {
                this.replacements = replacements;
            }

            public IDictionary<int, string> Replacements
            {
                get { return replacements; }
            }
        }
    }
}

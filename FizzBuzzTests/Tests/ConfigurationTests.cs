using System;
using FizzBuzzRunner.Configuration;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConfigurationTests
    {
        [Test]
        public void AppConfigRunnerSettings_should_have_default_Replacements()
        {
            var settings = GetAppConfigRunnerSettings();
            var result = settings.Replacements;

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test, Explicit("Run this when there are non Int32 values for divisors")]
        public void AppConfigRunnerSettings_throws_on_invalid_divisors()
        {
            var ex = Assert.Throws<ApplicationException>(() => GetAppConfigRunnerSettings());

            Assert.That(ex.Message, Contains.Substring("The divisor 'blah' is not a number."));
        }

        private AppConfigRunnerSettings GetAppConfigRunnerSettings()
        {
            return new AppConfigRunnerSettings();
        }
    }
}
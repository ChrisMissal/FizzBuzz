using System.Collections.Generic;
using System.Linq;
using FizzBuzz;

namespace FizzBuzzRunner.Configuration
{
    public class AppConfigRunnerSettings : IRunnerSettings
    {
        private readonly IDictionary<int, Replacement> replacements = new Dictionary<int, Replacement>();

        public AppConfigRunnerSettings()
        {
            var configuration = new Formo.Configuration("fizzBuzzPairs");

            var pairs = configuration.BindPairs<Replacement, int, string>(x => x.Key, x => x.Value);

            replacements = pairs
                    .Select(x => new Replacement { Key = x.Key, Value = x.Value })
                    .ToDictionary(x => x.Key);
        }

        public IDictionary<int, Replacement> Replacements
        {
            get { return replacements; }
        }
    }
}
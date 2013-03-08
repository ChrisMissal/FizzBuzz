using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class DefaultRunnerSettings : IRunnerSettings
    {
        private readonly IDictionary<int, string> replacements = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"},
        };

        public IDictionary<int, Replacement> Replacements
        {
            get
            {
                return replacements
                    .Select(x => new Replacement { Key = x.Key, Value = x.Value })
                    .ToDictionary(x => x.Key);
            }
        }
    }
}
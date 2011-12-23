using System;
using System.Collections.Generic;
using System.Configuration;
using FizzBuzz;

namespace FizzBuzzRunner.Configuration
{
    public class AppConfigRunnerSettings : IRunnerSettings
    {
        private readonly IDictionary<int, string> replacements = new Dictionary<int, string>();

        public AppConfigRunnerSettings()
        {
            var section = (ReplacementsConfigurationSection)ConfigurationManager.GetSection("Replacements");
            foreach (ReplacementElement item in section.ReplacementItems)
            {
                int divisor;
                if (!Int32.TryParse(item.Divisor, out divisor))
                    throw new ApplicationException(string.Format("Invalid setting. The divisor '{0}' is not a number.", item.Divisor));

                replacements.Add(divisor, item.ReplacementString);
            }
        }

        public IDictionary<int, string> Replacements
        {
            get { return replacements; }
        }
    }
}
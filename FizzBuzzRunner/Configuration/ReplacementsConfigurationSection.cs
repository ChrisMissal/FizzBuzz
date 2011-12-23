using System.Configuration;

namespace FizzBuzzRunner.Configuration
{
    public class ReplacementsConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("ReplacementItems")]
        public ReplacementsCollection ReplacementItems
        {
            get { return ((ReplacementsCollection)(base["ReplacementItems"])); }
        }
    }
}
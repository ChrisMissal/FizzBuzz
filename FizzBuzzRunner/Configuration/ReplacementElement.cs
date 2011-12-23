using System.Configuration;

namespace FizzBuzzRunner.Configuration
{
    public class ReplacementElement : ConfigurationElement
    {
        [ConfigurationProperty("divisor", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Divisor
        {
            get { return ((string)(base["divisor"])); }
        }

        [ConfigurationProperty("replacementString", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string ReplacementString
        {
            get { return ((string)(base["replacementString"])); }
        }
    }
}
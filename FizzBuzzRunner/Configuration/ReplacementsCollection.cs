using System.Configuration;

namespace FizzBuzzRunner.Configuration
{
    [ConfigurationCollection(typeof(ReplacementElement))]
    public class ReplacementsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ReplacementElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ReplacementElement)(element)).Divisor;
        }
    }
}
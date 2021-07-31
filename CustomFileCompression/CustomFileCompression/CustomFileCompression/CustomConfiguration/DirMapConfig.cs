using System.Configuration;

namespace CustomFileCompression.CustomConfiguration
{
    public class DirMapConfig : ConfigurationSection
    {
        // Create a property that lets us access the collection
        // of CustomConfigurationElement

        // Specify the name of the element used for the property
        [ConfigurationProperty("DirectoriesMapping")]
        // Specify the type of elements found in the collection
        [ConfigurationCollection(typeof(CustomConfigurationCollection))]
        public CustomConfigurationCollection DirectoryMapping
        {
            get
            {
                // Get the collection and parse it
                return (CustomConfigurationCollection)this["DirectoriesMapping"];
            }
        }
    }
}

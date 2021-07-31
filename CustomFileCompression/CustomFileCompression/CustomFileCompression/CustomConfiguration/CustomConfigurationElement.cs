using System.Configuration;

namespace CustomFileCompression.CustomConfiguration
{
    public class CustomConfigurationElement : ConfigurationElement
    {
        // Create a property to store the name of the Source directory
        // - The "SourceDirname" is the name of the XML attribute for the property
        // - The IsKey setting specifies that this field is used to identify
        //   element uniquely
        // - The IsRequired setting specifies that a value is required
        [ConfigurationProperty("SourceDirname", IsKey = true, IsRequired = true)]
        public string SourceDirname
        {
            get
            {
                // Return the value of the 'name' attribute as a string
                return (string)base["SourceDirname"];
            }
            set
            {
                // Set the value of the 'name' attribute
                base["SourceDirname"] = value;
            }
        }

        [ConfigurationProperty("DestinationDirname", IsRequired = true)]
        public string DestinationDirname
        {
            get
            {
                // Return the value of the 'name' attribute as a string
                return (string)base["DestinationDirname"];
            }
            set
            {
                // Set the value of the 'name' attribute
                base["DestinationDirname"] = value;
            }
        }

        [ConfigurationProperty("FileStabilityTimeInSeconds", IsRequired = false, DefaultValue = "60")]
        public string FileStabilityTimeInSeconds
        {
            get
            {
                // Return the value of the 'name' attribute as a string
                return (string)base["FileStabilityTimeInSeconds"];
            }
            set
            {
                // Set the value of the 'name' attribute
                base["FileStabilityTimeInSeconds"] = value;
            }
        }
    }
}

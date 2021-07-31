using System.Configuration;

namespace CustomFileCompression.CustomConfiguration
{
    public class CustomConfigurationCollection : ConfigurationElementCollection
    {
        // Create a property that lets us access an element in the
        // collection with the int index of the element
        public CustomConfigurationElement this[int index]
        {
            get
            {
                // Gets the CustomConfigurationElement at the specified
                // index in the collection
                return (CustomConfigurationElement)BaseGet(index);
            }
            set
            {
                // Check if a CustomConfigurationElement exists at the
                // specified index and delete it if it does
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                // Add the new CustomConfigurationElement at the specified
                // index
                BaseAdd(index, value);
            }
        }

        // Create a property that lets us access an element in the
        // colleciton with the name of the element
        public new CustomConfigurationElement this[string key]
        {
            get
            {
                // Gets the CustomConfigurationElement where the name
                // matches the string key specified
                return (CustomConfigurationElement)BaseGet(key);
            }
            set
            {
                // Checks if a CustomConfigurationElement exists with
                // the specified name and deletes it if it does
                if (BaseGet(key) != null)
                    BaseRemoveAt(BaseIndexOf(BaseGet(key)));

                // Adds the new CustomConfigurationElement
                BaseAdd(value);
            }
        }

        // Method that must be overriden to create a new element
        // that can be stored in the collection
        protected override ConfigurationElement CreateNewElement()
        {
            return new CustomConfigurationElement();
        }

        // Method that must be overriden to get the key of a
        // specified element
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((CustomConfigurationElement)element).SourceDirname;
        }
    }
}

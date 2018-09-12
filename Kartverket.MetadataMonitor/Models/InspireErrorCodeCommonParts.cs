using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Kartverket.MetadataMonitor.Models
{
    public class InspireErrorCodeCommonParts : ConfigurationSection
    {
        [ConfigurationProperty("Items", IsDefaultCollection = true)]
        public Items Items
        {
            get
            {
                return (Items)base["Items"];
            }
        }
    }

    public class Items : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new InspireErrorCodeCommonPart();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((InspireErrorCodeCommonPart)element).Index;
        }

        public static implicit operator List<string>(Items items)
        {
            List<string> stringList = new List<string>();

            foreach (InspireErrorCodeCommonPart item in items)
            {
                stringList.Add(item.Value);
            }
            return stringList;
        }
    }

    public class InspireErrorCodeCommonPart : ConfigurationElement
    {
        [ConfigurationProperty("index", IsRequired = true, IsKey = true)]
        public int Index
        {
            get
            {
                return (int)this["index"];
            }
        }

        [ConfigurationProperty("value", IsRequired = true)]
        public string Value
        {
            get
            {
                return (string)this["value"];
            }
        }
    }
}
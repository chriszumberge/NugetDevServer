using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NugetDevServer.Configuration
{
    [ConfigurationCollection(typeof(CredentialElement), CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class CredentialElementCollection : ConfigurationElementCollection
    {
        public CredentialElement this[int index]
        {
            get
            {
                return (CredentialElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new CredentialElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((CredentialElement)element).UserName;
        }
    }
}
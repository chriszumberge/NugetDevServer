using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NugetDevServer.Configuration
{
    public class BasicAuthenticationConfigurationSection : ConfigurationSection
    {
        private const string CredentialsNode = "credentials";

        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>
        /// The credentials.
        /// </value>
        [ConfigurationProperty(CredentialsNode, IsRequired = false)]
        public CredentialElementCollection Credentials
        {
            get { return (CredentialElementCollection)this[CredentialsNode]; }
            set { this[CredentialsNode] = value; }
        }
    }
}
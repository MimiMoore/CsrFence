using System.Configuration;

namespace Altairis.CsrFence.Configuration
{

    public class SessionIdElement : ConfigurationElement
    {

        [ConfigurationProperty("length", IsRequired = false, DefaultValue = 64)]
        [IntegerValidator(MinValue = 32, MaxValue = 128)]
        public int Length {
            get => (int)this["length"];
            set => this["length"] = value;
        }

        [ConfigurationProperty("cookieName", IsRequired = false, DefaultValue = ".CSRFENCE")]
        public string CookieName {
            get => (string)this["cookieName"];
            set => this["cookieName"] = value;
        }

        [ConfigurationProperty("cookieSameSite", IsRequired = false, DefaultValue = "")]
        public string CookieSameSite {
            get => (string)this["cookieSameSite"];
            set => this["cookieSameSite"] = value;
        }


    }
}
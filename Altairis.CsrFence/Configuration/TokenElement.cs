using System.Configuration;

namespace Altairis.CsrFence.Configuration {

    public class TokenElement : ConfigurationElement {

        [ConfigurationProperty("fieldName", IsRequired = false, DefaultValue = "__CSRFTOKEN")]
        public string FieldName {
            get => (string)this["fieldName"];
            set => this["fieldName"] = value;
        }

        [ConfigurationProperty("purposeString", IsRequired = false, DefaultValue = "Altairis.CsrFence.ProtectionModule.Token")]
        public string PurposeString {
            get => (string)this["purposeString"];
            set => this["purposeString"] = value;
        }
    }
}
using System.Configuration;

namespace Altairis.CsrFence.Configuration {

    public class CsrFenceSection : ConfigurationSection {

        [ConfigurationProperty("sessionId")]
        public SessionIdElement SessionId {
            get => (SessionIdElement)this["sessionId"];
            set => this["sessionId"] = value;
        }

        [ConfigurationProperty("token")]
        public TokenElement Token {
            get => (TokenElement)this["token"];
            set => this["token"] = value;
        }

    }

}

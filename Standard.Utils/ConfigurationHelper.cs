#if net46
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Standard.Utils
{
    public static class ConfigurationHelper
    {
        public static NameValueCollection GetSection(string key)
        {
            var o = ConfigurationManager.GetSection(key);
            if (o == null)
                throw new ConfigurationErrorsException(
                    String.Format("Section '{0}' could not be found in the configuration file.", key));
            return (NameValueCollection) o;
        }
    }
}
#endif

using System.Collections.Generic;
using System.Text;
using TangoCard.Raas.Utilities;
using TangoCard.Raas.Models;
namespace TangoCard.Raas
{
    public partial class Configuration
    {

        public enum Environments
        {
            //The sandbox environment does not use real money and can be used for testing.
            SANDBOX,
            //The production environment uses real money and is for live transactions.
            PRODUCTION,
        }
        public enum Servers
        {
            ENUM_DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.SANDBOX;

        //Platform Name (Provided by Tango Card)
        //TODO: Replace the PlatformName with an appropriate value
        public static string PlatformName = "QAPlatform2";

        //Platform Key (Provided by Tango Card)
        //TODO: Replace the PlatformKey with an appropriate value
        public static string PlatformKey = "apYPfT6HNONpDRUj3CLGWYt7gvIHONpDRUYPfT6Hj";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.SANDBOX,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://integration-api.tangocard.com/raas/v2" },
                    }
                },
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://api.tangocard.com/raas/v2" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ENUM_DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}
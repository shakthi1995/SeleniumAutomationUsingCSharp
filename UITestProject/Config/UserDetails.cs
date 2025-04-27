using Newtonsoft.Json;
using SeleniumAutomation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Config
{
    public class UserDetails
    {
        private static readonly string configPath = "config.json";
        private static readonly string username;
        private static readonly string password;
        private static readonly string url;
        static UserDetails()
        {
            var file = File.ReadAllText(configPath);
            EnvVariables config = JsonConvert.DeserializeObject<EnvVariables>(file);

            switch (config.env)
            {
                case "dev":
                    username = Base64Decode(config.userInfoDev.username);
                    password = Base64Decode(config.userInfoDev.password);
                    url = config.url.devUrl;
                    break;

                case "stage":
                    username = Base64Decode(config.userInfoStage.username);
                    password = Base64Decode(config.userInfoStage.password);
                    url = config.url.stageUrl;
                    break;
            }
          
        }

        public static string GetUrl => url;
        public static string GetUserName => username;
        public static string GetPassword => password;

        static string Base64Encode(string input)
        {
            var textBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(textBytes);
        }

        static string Base64Decode(string input)
        {
            var text = Convert.FromBase64String(input);
            return Encoding.UTF8.GetString(text);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Model
{
    public class EnvVariables
    {
        public string env { get; set; }
        public Url url { get; set; }
        public Userinfodev userInfoDev { get; set; }
        public Userinfostage userInfoStage { get; set; }
    }

    public class Url
    {
        public string devUrl { get; set; }
        public string stageUrl { get; set; }
    }

    public class Userinfodev
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class Userinfostage
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}

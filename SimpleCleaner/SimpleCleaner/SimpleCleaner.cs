
/*
    ooooo   ooooo                     .o8        .ooooo.   
    `888'   `888'                    "888       888' `Y88. 
     888     888   .ooooo.  oooo d8b  888oooo.  888    888 
     888ooooo888  d88' `88b `888""8P  d88' `88b  `Vbood888 
     888     888  888ooo888  888      888   888       888' 
     888     888  888    .o  888      888   888     .88P'  
    o888o   o888o `Y8bod8P' d888b     `Y8bod8P'   .oP'     

    Directed by Herb9.
*/

using System;

using System.Net;

using System.Text;

using Newtonsoft.Json.Linq;

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

using MiNET.Utils;

namespace SimpleCleaner
{

    [Plugin(
        PluginName = "SimpleCleaner",
        Description = "The easiest way to clean your chat.",
        PluginVersion = "1.1",
        Author = "Herb9"
        )]
    public class SimpleCleaner : Plugin
    {

        private string Prefix = "";

        protected override void OnEnable()
        {
            CheckUpdate();
        }

        [Command(
            Name = "cls",
            Description = "Cleaning chat command."
            )]
        public void ClsCommand(Player sender)
        {
            int num = 0;

            do
            {
                sender.SendMessage($"{ChatColors.White}\n");

                num++;
            }

            while(num < 20);
        }

        private void CheckUpdate()
        {
            byte[] base64 = Convert.FromBase64String("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0hlcmJQbHVnaW5zL1NpbXBsZUNsZWFuZXIvbWFzdGVyL1NpbXBsZUNsZWFuZXIvU2ltcGxlQ2xlYW5lci9wbHVnaW4uanNvbg==");

            var url = new WebClient().DownloadString(Encoding.UTF8.GetString(base64));

            dynamic plugin = JObject.Parse(url);

            if(plugin.Info.Version > 1.1)
            {
                Console.WriteLine($"{Prefix} New version has been found, Please go to {plugin.Info.Url} and download new version plugin.");

                Context.Server.StopServer();
            }

            Console.WriteLine($"{Prefix} You are currently using the latest version.");

            Console.WriteLine($"{Prefix} SimpleCleaner v1.1 successfully enabled.");
        }
    }
}

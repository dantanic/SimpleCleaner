
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

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

using Newtonsoft.Json.Linq;

using System;
using System.Net;
using System.Text;

namespace SimpleCleaner
{

    [Plugin(PluginName = "SimpleCleaner", Description = "The easiest way to clean your chat.", PluginVersion = "1.2", Author = "Herb9")]
    public class SimpleCleaner : Plugin
    {

        public const string Prefix = "\x5b\x53\x69\x6d\x70\x6c\x65\x43\x6c\x65\x61\x6e\x65\x72\x5d";

        protected override void OnEnable()
        {
            CheckUpdate();
        }

        [Command(Name = "cls", Description = "Cleaning chat command.")]
        public void ClsCommand(Player sender)
        {
            for (int i = 0; i < 20; ++i)
                sender.SendMessage("§f\n");
        }

        private void CheckUpdate()
        {
            byte[] url = Convert.FromBase64String("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0hlcmJQbHVnaW5zL1NpbXBsZUNsZWFuZXIvbWFzdGVyL1NpbXBsZUNsZWFuZXIvU2ltcGxlQ2xlYW5lci9wbHVnaW4uanNvbg==");

            dynamic update = JObject.Parse(new WebClient().DownloadString(Encoding.UTF8.GetString(url)));

            if (update.Version > 1.2)
                Console.WriteLine(Prefix + " New version has been found, Please inquire developer or download new version.");

            else
                Console.WriteLine(Prefix + " SimpleCleaner v1.2 successfully enabled.");
        }
    }
}

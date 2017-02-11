
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

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

using MiNET.Utils;

namespace SimpleCleaner
{

    [Plugin(
        PluginName = "SimpleCleaner",
        Description = "The easiest way to clean your chat.",
        PluginVersion = "1.0",
        Author = "Herb9"
        )]
    public class SimpleCleaner : Plugin
    {

        protected override void OnEnable()
        {
            Console.WriteLine("[SimpleCleaner] SimpleCleaner v1.0 successfully enabled.");
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
    }
}

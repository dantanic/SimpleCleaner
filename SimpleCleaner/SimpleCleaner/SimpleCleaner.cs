﻿
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

namespace SimpleCleaner
{

    public class SimpleCleaner : Plugin
    {

        private const string Prefix = "\x5b\x53\x69\x6d\x70\x6c\x65\x43\x6c\x65\x61\x6e\x65\x72\x5d";

        protected override void OnEnable()
        {
            Console.WriteLine($"{Prefix} Successfully enabled.");
        }

        [Command(
            Name = "cls",
            Description = "Clean up your chatting windows simply."
            )]
        public void CleanUpCommand(Player sender)
        {

        }
    }
}

using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Rocket.API.Collections;

namespace educatalan02.AutoSaveKingModdingNetwork
{
    public class AutoSaveMain : RocketPlugin<AutoSaveConfig>
    {
        public static AutoSaveMain Instance = null;

        Func<Color> colorify = () => UnturnedChat.GetColorFromName(AutoSaveMain.Instance.Configuration.Instance.Color, Color.yellow);

        protected override void Load()
        
        {
            Instance = this;



            Rocket.Core.Logging.Logger.Log("Plugin Loaded correctly. Made by educatalan02");
            Rocket.Core.Logging.Logger.Log("If you have issues join to this discord: https://discord.gg/Q89FmUk");
            Rocket.Core.Logging.Logger.Log("Plugin version: 2.5.0.1");

            if (Configuration.Instance.SaveServerEnabled)
            InvokeRepeating("SaveServer", Configuration.Instance.SaveServerInterval, Configuration.Instance.SaveServerInterval);

            if (Configuration.Instance.SaveVehiclesEnabled)
            InvokeRepeating("SaveVehicles", Configuration.Instance.SaveVehiclesInterval, Configuration.Instance.SaveVehiclesInterval);
        }


        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Plugin unloaded");
            CancelInvoke("SaveServer");
			CancelInvoke("SaveVehicles");
        }




        public void SaveServer()
        {
            UnturnedChat.Say(Configuration.Instance.SaveServerMsg, colorify());
            Rocket.Core.Logging.Logger.Log("Server Saving...!");
            SaveManager.save();
        
            
        }
        public void SaveVehicles()
        {
            UnturnedChat.Say(Configuration.Instance.SaveVehiclesMsg, colorify());
            Rocket.Core.Logging.Logger.Log("Vehicles Saving...!");
            SaveManager.save();


        }
        // The ability to replace it for SaveMsg
        public override TranslationList DefaultTranslations => new TranslationList()
        {
            {"Saving", "Saving server..."}
        };
    }
}

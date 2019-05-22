using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using UnityEngine;

namespace educatalan02.AutoSaveKingModdingNetwork
{
    public class AutoSaveConfig : IRocketPluginConfiguration

    {
        public float SaveVehiclesInterval;
        public float SaveServerInterval;
        public string UrlServer;
        public bool SaveServerEnabled;
        public bool SaveVehiclesEnabled;
        public string SaveServerMsg;
        public string UrlVehicle;
        public string SaveVehiclesMsg;

        public void LoadDefaults()
        {
            SaveServerMsg = "{color=yellow}[Info] {/color} {color=red}Saving Server...{/color}";
            SaveVehiclesMsg = "{color=yellow}[Info] {/color} {color=white}Saving Vehicles...{/color}";
            SaveServerEnabled = true;
            SaveVehiclesEnabled = true;
            SaveServerInterval = 600f;
            UrlVehicle = "LINK OF IMAGE";
            SaveVehiclesInterval = 600f;
            UrlServer = "LINK OF IMAGE";
        }
    }
}

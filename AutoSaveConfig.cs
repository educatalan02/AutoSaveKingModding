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
        public string Color;
        public bool SaveServerEnabled;
        public bool SaveVehiclesEnabled;
        public string SaveServerMsg;
        public string SaveVehiclesMsg;

        public void LoadDefaults()
        {
            SaveServerMsg = "Saving Server...";
            SaveVehiclesMsg = "Saving Vehicles...";
            SaveServerEnabled = true;
            SaveVehiclesEnabled = true;
            SaveServerInterval = 600f;
            SaveVehiclesInterval = 600f;
            Color = "yellow";
        }
    }
}

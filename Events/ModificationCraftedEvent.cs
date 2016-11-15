﻿using EddiDataDefinitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddiEvents
{
    public class ModificationCraftedEvent : Event
    {
        public const string NAME = "Modification crafted";
        public const string DESCRIPTION = "Triggered when you craft a modification to a module";
        public const string SAMPLE = @"{ ""timestamp"":""2016-11-14T18:49:29Z"", ""event"":""EngineerCraft"", ""Engineer"":""Broo Tarquin"", ""Blueprint"":""Weapon_RapidFire"", ""Level"":5, ""Ingredients"":{""powertransferconduits"":1, ""precipitatedalloys"":1, ""configurablecomponents"":1, ""technetium"":1 } }";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static ModificationCraftedEvent()
        {
            VARIABLES.Add("engineer", "The name of the engineer crafting the modification");
            VARIABLES.Add("blueprint", "The blueprint being crafted");
            VARIABLES.Add("level", "The level of the blueprint being crafted");
            VARIABLES.Add("materials", "The materials and quantities used in the crafting (MaterialAmount object)");
        }

        [JsonProperty("engineer")]
        public string engineer { get; private set; }

        [JsonProperty("blueprint")]
        public string blueprint{ get; private set; }

        [JsonProperty("level")]
        public int level { get; private set; }

        [JsonProperty("materials")]
        public List<MaterialAmount> materials { get; private set; }

        public ModificationCraftedEvent(DateTime timestamp, string engineer, string blueprint, int level, List<MaterialAmount> materials) : base(timestamp, NAME)
        {
            this.engineer = engineer;
            this.blueprint = blueprint;
            this.level = level;
            this.materials = materials;
        }
    }
}

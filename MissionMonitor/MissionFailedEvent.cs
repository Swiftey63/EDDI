﻿using EddiEvents;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EddiMissionMonitor
{
    public class MissionFailedEvent: Event
    {
        public const string NAME = "Mission failed";
        public const string DESCRIPTION = "Triggered when you fail a mission";
        public const string SAMPLE = "{ \"timestamp\":\"2016-09-25T12:53:01Z\", \"event\":\"MissionFailed\", \"Name\":\"Mission_PassengerVIP_name\", \"MissionID\":26493517 }";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static MissionFailedEvent()
        {
            VARIABLES.Add("missionid", "The ID of the mission");
            VARIABLES.Add("name", "The name of the mission");
            VARIABLES.Add("fine", "The fine levied");
        }

        [JsonProperty("missionid")]
        public long? missionid { get; private set; }

        [JsonProperty("name")]
        public string name { get; private set; }

        [JsonProperty("fine")]
        public long fine { get; private set; }

        public MissionFailedEvent(DateTime timestamp, long? missionid, string name, long fine) : base(timestamp, NAME)
        {
            this.missionid = missionid;
            this.name = name;
            this.fine = fine;
        }
    }
}

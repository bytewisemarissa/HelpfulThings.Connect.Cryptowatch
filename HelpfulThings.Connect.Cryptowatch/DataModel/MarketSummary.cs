﻿using Newtonsoft.Json;

namespace HelpfulThings.Connect.Cryptowatch.DataModel
{
    public class MarketSummary
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "exchange")]
        public string Exchange { get; set; }

        [JsonProperty(PropertyName = "pair")]
        public string Pair { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "route")]
        public string Route { get; set; }
    }
}

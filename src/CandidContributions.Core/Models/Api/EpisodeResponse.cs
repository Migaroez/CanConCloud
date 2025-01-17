﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace CandidContributions.Core.Models.Api
{
    public class EpisodeResponse
    {
        
        [JsonProperty("items")]
        public List<EpisodeModel> Items { get; set; }

        [JsonProperty("episode")]
        public EpisodeModel Episode { get; set; }

    }
}
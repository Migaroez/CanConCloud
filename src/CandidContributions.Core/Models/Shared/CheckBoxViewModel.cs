﻿using Newtonsoft.Json;

namespace CandidContributions.Core.Models.Shared
{
    public class CheckBoxViewModel
    {
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("checked")]
        public bool Checked { get; set; }
    }
}
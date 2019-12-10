using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitNow.Models
{
    public class BitCoinModel
    {
        [JsonProperty("base")]
        public Int64 Base { get; set; }

        [JsonProperty("currency")]
        public int Currency { get; set; }

        [JsonProperty("amount")]
        public string amount { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

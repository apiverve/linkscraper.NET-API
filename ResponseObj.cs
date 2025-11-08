using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Links data
    /// </summary>
    public class Links
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("external")]
        public bool External { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("linkCount")]
        public int LinkCount { get; set; }

        [JsonProperty("links")]
        public Links[] Links { get; set; }

        [JsonProperty("maxLinksReached")]
        public bool MaxLinksReached { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}

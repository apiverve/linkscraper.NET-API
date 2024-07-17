using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class links
{
    [JsonProperty("external")]
    public bool external { get; set; }

    [JsonProperty("href")]
    public string href { get; set; }

    [JsonProperty("text")]
    public string text { get; set; }

}

public class data
{
    [JsonProperty("linkCount")]
    public int linkCount { get; set; }

    [JsonProperty("links")]
    public links[] links { get; set; }

    [JsonProperty("maxLinksReached")]
    public bool maxLinksReached { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}

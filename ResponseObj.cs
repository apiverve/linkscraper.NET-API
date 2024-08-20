using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class links
{
    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("href")]
    public string href { get; set; }

    [JsonProperty("external")]
    public bool external { get; set; }

}

public class data
{
    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("linkCount")]
    public int linkCount { get; set; }

    [JsonProperty("links")]
    public links[] links { get; set; }

    [JsonProperty("maxLinksReached")]
    public bool maxLinksReached { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}

using System;
using System.Collections.Generic;
using System.Text;

namespace APIVerve
{
    public class QueryOptions {
using Newtonsoft.Json;

public class ResponseObj
{
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("error")]
    public string Error { get; set; }

    [JsonProperty("data")]
    public object Data { get; set; }

}
}

}

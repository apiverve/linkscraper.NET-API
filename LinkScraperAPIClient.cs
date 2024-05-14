using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace APIVerve
{
    public class LinkScraperAPIClient
    {
        private readonly string _apiEndpoint = "https://api.apiverve.com/v1/linkscraper";
        private readonly string _method = "POST";

        private string _apiKey { get; set; }
        private bool _isSecure { get; set; }
        private bool _isDebug { get; set; }

        public LinkScraperAPIClient(string apiKey, bool isSecure = true)
        {
            _apiKey = apiKey;
            _isSecure = isSecure;
        }

        public LinkScraperAPIClient(string apiKey, bool isSecure = true, bool isDebug = false)
        {
            _apiKey = apiKey;
            _isSecure = isSecure;
            _isDebug = isDebug;
        }

        public string GetApiKey() => _apiKey;
        public bool GetIsSecure() => _isSecure;
        public bool GetIsDebug() => _isDebug;

        public void SetApiKey(string apiKey) => _apiKey = apiKey;
        public void SetIsSecure(bool isSecure) => _isSecure = isSecure;
        public void SetIsDebug(bool isDebug) => _isDebug = isDebug;
        public string GetApiEndpoint() => _apiEndpoint;

        public ResponseObj Execute(QueryOptions options)
        {
            try
            {
                if(_isDebug)
                {
                    Console.WriteLine("Executing API request...");
                }

                var url = constructURL(options);

                if (_isDebug)
                {
                    Console.WriteLine("URL: " + url);
                }

                // Make the request using HTTPClient
                var client = new System.Net.Http.HttpClient();
                client.DefaultRequestHeaders.Add("x-api-key", _apiKey);

                var responseString = "";

                if (_method == "POST")
                {
                    // Make a GET request
                    var getResponse = client.GetAsync(url).Result;
                    responseString = getResponse.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    // Make a POST request, body is the options object
                    var body = JsonConvert.SerializeObject(options);
                    var content = new System.Net.Http.StringContent(body, System.Text.Encoding.UTF8, "application/json");
                    var postResponse = client.PostAsync(url, content).Result;

                    responseString = postResponse.Content.ReadAsStringAsync().Result;
                }

                if(_isDebug)
                {
                    Console.WriteLine("Response: " + responseString);
                }

                if (string.IsNullOrEmpty(responseString))
                {
                    throw new Exception("No response from the server");
                }

                // Using newtonsoft.json to parse the response string
                var responseObj = JsonConvert.DeserializeObject<ResponseObj>(responseString);
                return responseObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private string constructURL(QueryOptions options)
        {
            string url = _apiEndpoint;

            // Convert all the option properties of the object to a query string, using iteration
            string query = "";
            if (_method == "POST")
            {
                foreach (var prop in options.GetType().GetProperties())
                {
                    query += prop.Name + "=" + prop.GetValue(options, null) + "&";
                }

                // Remove the last character of the query string, which is an extra "&"
                if (query.Length > 0 && query[query.Length - 1] == '&')
                {
                    query = query.Remove(query.Length - 1);
                }

                if (!string.IsNullOrEmpty(query))
                {
                    url += "?" + query;
                }
            }

            return url;
        }
    }    
}

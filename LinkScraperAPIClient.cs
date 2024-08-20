using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace APIVerve
{
    public class LinkScraperAPIClient
    {
        private readonly string _apiEndpoint = "https://api.apiverve.com/v1/linkscraper";
        private readonly string _method = "POST";

        private string _apiKey { get; set; }
        private bool _isSecure { get; set; }
        private bool _isDebug { get; set; }

        /// <summary>
        /// Provide your API key as part of the constructor
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="isSecure"></param>
        public LinkScraperAPIClient(string apiKey, bool isSecure = true)
        {
            _apiKey = apiKey;
            _isSecure = isSecure;
        }

        /// <summary>
        /// Provide your API key as part of the constructor
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="isSecure"></param>
        /// <param name="isDebug"></param>
        public LinkScraperAPIClient(string apiKey, bool isSecure = true, bool isDebug = false)
        {
            _apiKey = apiKey;
            _isSecure = isSecure;
            _isDebug = isDebug;
        }

        public bool GetIsSecure() => _isSecure;
        public bool GetIsDebug() => _isDebug;

        public void SetApiKey(string apiKey) => _apiKey = apiKey;
        public void SetIsSecure(bool isSecure) => _isSecure = isSecure;
        public void SetIsDebug(bool isDebug) => _isDebug = isDebug;
        public string GetApiEndpoint() => _apiEndpoint;

        public delegate void ExecuteAsyncCallback(ResponseObj result);


        /// <summary>
        /// Execute the API call asynchronously
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="options"></param>
        public void ExecuteAsync(ExecuteAsyncCallback callback, LinkScraperQueryOptions options = null)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                ResponseObj result = Execute(options);
                callback(result);
            });
        }

        /// <summary>
        /// Execute the API call synchronously
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public ResponseObj Execute(LinkScraperQueryOptions options = null)
        {
            try
            {
                if (_isDebug)
                {
                    Console.WriteLine("Executing API request...");
                }

                var url = constructURL(options);

                if (_isDebug)
                {
                    Console.WriteLine("URL: " + url);
                }

                var request = WebRequest.Create(url);
                request.Headers["x-api-key"] = _apiKey;
                request.Headers["auth-mode"] = "nuget-package";
                request.Method = _method;

                if (_method == "POST")
                {
                    if(options == null)
                    {
                        throw new Exception("Options are required for this call");
                    }

                    var body = JsonConvert.SerializeObject(options);
                    var data = Encoding.UTF8.GetBytes(body);

                    request.ContentType = "application/json";
                    request.ContentLength = data.Length;

                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }

                string responseString;
                try
                {
                    using (var response = request.GetResponse())
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            responseString = reader.ReadToEnd();
                        }
                    }
                }
                catch (WebException e)
                {
                    using (var reader = new StreamReader(e.Response.GetResponseStream()))
                    {
                        responseString = reader.ReadToEnd();
                    }
                }

                if (_isDebug)
                {
                    Console.WriteLine("Response: " + responseString);
                }

                if (string.IsNullOrEmpty(responseString))
                {
                    throw new Exception("No response from the server");
                }

                var responseObj = JsonConvert.DeserializeObject<ResponseObj>(responseString);
                return responseObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private string constructURL(LinkScraperQueryOptions options)
        {
            string url = _apiEndpoint;

            string query = "";
            if (options != null)
            {
                if (_method == "POST")
                {
                    foreach (var prop in options.GetType().GetProperties())
                    {
                        query += prop.Name + "=" + prop.GetValue(options, null) + "&";
                    }

                    if (query.Length > 0 && query[query.Length - 1] == '&')
                    {
                        query = query.Remove(query.Length - 1);
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        url += "?" + query;
                    }
                }
            }

            return url;
        }
    }
}

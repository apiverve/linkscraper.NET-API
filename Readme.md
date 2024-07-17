Link Scraper API
============

Link Scraper is a simple tool for scraping web page links. It returns all the links on a web page.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Link Scraper API](https://apiverve.com/marketplace/api/linkscraper)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.LinkScraper
```

Using the Package Manager:
```
nuget install APIVerve.API.LinkScraper
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.LinkScraper
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.LinkScraper".
5. Click on the APIVerve.API.LinkScraper package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the linkscraper API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Link Scraper API documentation is found here: [https://docs.apiverve.com/api/linkscraper](https://docs.apiverve.com/api/linkscraper).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Link Scraper API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new LinkScraperAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new linkscraperQueryOptions {
  url = "https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html",
  maxlinks = 20,
  includequery = false
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "linkCount": 16,
    "links": [
      {
        "external": false,
        "href": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html/pdfs/AWSEC2/latest/UserGuide/ec2-ug.pdf#concepts",
        "text": ""
      },
      {
        "external": true,
        "href": "https://aws.amazon.com",
        "text": "AWS"
      },
      {
        "external": false,
        "href": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html/index.html",
        "text": "Documentation"
      },
      {
        "external": false,
        "href": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html/ec2/index.html",
        "text": "Amazon EC2"
      },
      {
        "external": true,
        "href": "concepts.html",
        "text": "User Guide"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/ec2/latest/instancetypes/",
        "text": "Amazon EC2 Instance Types Guide"
      },
      {
        "external": true,
        "href": "https://aws.amazon.com/compliance/pci-dss-level-1-faqs/",
        "text": "PCI DSS Level 1"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/autoscaling",
        "text": "Amazon EC2 Auto Scaling"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/aws-backup",
        "text": "AWS Backup"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/cloudwatch",
        "text": "Amazon CloudWatch"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/elasticloadbalancing",
        "text": "Elastic Load Balancing"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/guardduty",
        "text": "Amazon GuardDuty"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/imagebuilder",
        "text": "EC2 Image Builder"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/launchwizard",
        "text": "AWS Launch Wizard"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/systems-manager",
        "text": "AWS Systems Manager"
      },
      {
        "external": true,
        "href": "https://docs.aws.amazon.com/lightsail",
        "text": "Amazon Lightsail"
      }
    ],
    "maxLinksReached": false,
    "url": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html"
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
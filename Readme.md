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
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.LinkScraper".
5. Click on the APIVerve.API.LinkScraper package, click Install.


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
var queryOptions = new LinkScraperQueryOptions {
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
    "url": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html",
    "linkCount": 16,
    "links": [
      {
        "text": "",
        "href": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html/pdfs/AWSEC2/latest/UserGuide/ec2-ug.pdf#concepts",
        "external": false
      },
      {
        "text": "Documentation",
        "href": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html/index.html",
        "external": false
      },
      {
        "text": "Amazon EC2",
        "href": "http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts.html/ec2/index.html",
        "external": false
      },
      {
        "text": "User Guide",
        "href": "concepts.html",
        "external": true
      },
      {
        "text": "Amazon EC2 Instance Types Guide",
        "href": "https://docs.aws.amazon.com/ec2/latest/instancetypes/instance-types.html",
        "external": true
      },
      {
        "text": "PCI DSS Level 1",
        "href": "https://aws.amazon.com/compliance/pci-dss-level-1-faqs/",
        "external": true
      },
      {
        "text": "Amazon EC2 Auto Scaling",
        "href": "https://docs.aws.amazon.com/autoscaling/",
        "external": true
      },
      {
        "text": "AWS Backup",
        "href": "https://docs.aws.amazon.com/aws-backup/",
        "external": true
      },
      {
        "text": "Amazon CloudWatch",
        "href": "https://docs.aws.amazon.com/cloudwatch/",
        "external": true
      },
      {
        "text": "Elastic Load Balancing",
        "href": "https://docs.aws.amazon.com/elasticloadbalancing/",
        "external": true
      },
      {
        "text": "Amazon GuardDuty",
        "href": "https://docs.aws.amazon.com/guardduty/",
        "external": true
      },
      {
        "text": "EC2 Image Builder",
        "href": "https://docs.aws.amazon.com/imagebuilder/",
        "external": true
      },
      {
        "text": "AWS Launch Wizard",
        "href": "https://docs.aws.amazon.com/launchwizard/",
        "external": true
      },
      {
        "text": "AWS Systems Manager",
        "href": "https://docs.aws.amazon.com/systems-manager/",
        "external": true
      },
      {
        "text": "Amazon Lightsail",
        "href": "https://docs.aws.amazon.com/lightsail/",
        "external": true
      },
      {
        "text": "Amazon Lightsail or Amazon EC2",
        "href": "https://docs.aws.amazon.com/decision-guides/latest/lightsail-or-ec2/lightsail-or-ec2.html",
        "external": true
      }
    ],
    "maxLinksReached": false
  },
  "code": 200
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

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
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
var queryOptions = new linkscraperQueryOptions{
  "url": "myspace.com",
  "maxlinks": 100,
  "includequery": false
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response.data, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "url": "http://myspace.com",
    "linkCount": 98,
    "links": [
      {
        "text": "Myspace",
        "href": "http://myspace.com/",
        "external": false
      },
      {
        "text": "Search",
        "href": "http://myspace.com/search",
        "external": false
      },
      {
        "text": "Featured",
        "href": "http://myspace.com/discover/featured",
        "external": false
      },
      {
        "text": "Music",
        "href": "http://myspace.com/discover/songs",
        "external": false
      },
      {
        "text": "Videos",
        "href": "http://myspace.com/discover/videos",
        "external": false
      },
      {
        "text": "People",
        "href": "http://myspace.com/discover/people",
        "external": false
      },
      {
        "text": "Help",
        "href": "http://myspace.com/help",
        "external": false
      },
      {
        "text": "Privacy",
        "href": "http://myspace.com/pages/privacy",
        "external": false
      },
      {
        "text": "Terms",
        "href": "http://myspace.com/pages/terms",
        "external": false
      },
      {
        "text": "Ad Opt-Out",
        "href": "http://myspace.com/pages/privacy",
        "external": false
      },
      {
        "text": "Do-Not-Sell My Personal Information",
        "href": "http://myspace.com/pages/privacy",
        "external": false
      },
      {
        "text": "Report Abuse",
        "href": "http://myspace.com/reportabuse",
        "external": false
      },
      {
        "text": "Red Hot Chili Peppers, Nine Inch Nails, Slipknot and KISS to Headline Louder Than Life Lineup",
        "href": "http://myspace.com/article/2022/3/9/red-hot-chili-peppers-nine-inch-nails-slipknot-and-kiss-to-headline-louder-than-life-lineup-spin",
        "external": false
      },
      {
        "text": "Charli XCX shares full ‘Crash’ track listing",
        "href": "http://myspace.com/article/2022/3/11/charli-xcx-shares-full-crash-track-listing-nme",
        "external": false
      },
      {
        "text": "Fly Anakin Carves His Own Lane on Frank",
        "href": "http://myspace.com/article/2022/3/14/fly-anakin-carves-his-own-lane-on-frank",
        "external": false
      },
      {
        "text": "Rammstein share powerful new ballad ‘Zeit’ and unveil new album",
        "href": "http://myspace.com/article/2022/3/11/rammstein-share-powerful-new-ballad-zeit-and-unveil-new-album-nme",
        "external": false
      },
      {
        "text": "Deftones Part Ways With Bassist Sergio Vega",
        "href": "http://myspace.com/article/2022/3/9/deftones-part-ways-with-bassist-sergio-vega-spin",
        "external": false
      },
      {
        "text": "Florence Pugh in talks to star in ‘Dune: Part Two’",
        "href": "http://myspace.com/article/2022/3/9/florence-pugh-in-talks-to-star-in-dune-part-two-nme",
        "external": false
      },
      {
        "text": "Katelyn Ryan\n\t\t\t\t\t\t\tMember",
        "href": "http://myspace.com//myspace.com/katelynryry",
        "external": false
      },
      {
        "text": "Calvin Harris\n\t\t\t\t\t\t\tMusician",
        "href": "http://myspace.com//myspace.com/calvinharris",
        "external": false
      },
      {
        "text": "Patrick McCloud\n\t\t\t\t\t\t\tMember",
        "href": "http://myspace.com//myspace.com/pmccloud",
        "external": false
      },
      {
        "text": "Ashley Benson\n\t\t\t\t\t\t\tArtist, Actor",
        "href": "http://myspace.com//myspace.com/ashleyy.benson",
        "external": false
      },
      {
        "text": "NEWS",
        "href": "http://myspace.com/articles/news",
        "external": false
      },
      {
        "text": "ARTIST OF THE DAY",
        "href": "http://myspace.com/articles/artist-of-the-day",
        "external": false
      },
      {
        "text": "Q&A",
        "href": "http://myspace.com/articles/q-a",
        "external": false
      },
      {
        "text": "EVERYBODY LOVES A LIST!",
        "href": "http://myspace.com/articles/everybody-loves-a-list",
        "external": false
      },
      {
        "text": "TOP 8",
        "href": "http://myspace.com/articles/top-8",
        "external": false
      },
      {
        "text": "PORTRAITS",
        "href": "http://myspace.com/articles/portraits",
        "external": false
      },
      {
        "text": "FREE LUNCH",
        "href": "http://myspace.com/articles/free-lunch",
        "external": false
      },
      {
        "text": "10 THINGS",
        "href": "http://myspace.com/articles/10-things",
        "external": false
      },
      {
        "text": "PROFILING",
        "href": "http://myspace.com/articles/profiling",
        "external": false
      },
      {
        "text": "PREMIERE",
        "href": "http://myspace.com/articles/premiere",
        "external": false
      },
      {
        "text": "CROWD SURFING",
        "href": "http://myspace.com/articles/crowd-surfing",
        "external": false
      },
      {
        "text": "TATTOOSDAY",
        "href": "http://myspace.com/articles/tattoosday",
        "external": false
      },
      {
        "text": "WRESTLING WEDNESDAY",
        "href": "http://myspace.com/articles/wrestling-wednesday",
        "external": false
      },
      {
        "text": "NEW MUSIC FRIDAY",
        "href": "http://myspace.com/articles/new-music-friday",
        "external": false
      },
      {
        "text": "MIKE'S FAVORITE THINGS ON THE INNERWEBS",
        "href": "http://myspace.com/articles/mikes-favorite-things-on-the-innerwebs",
        "external": false
      },
      {
        "text": "PLAYLIST",
        "href": "http://myspace.com/articles/playlist",
        "external": false
      },
      {
        "text": "FEATURE",
        "href": "http://myspace.com/articles/feature",
        "external": false
      },
      {
        "text": "IN MEMORIAM",
        "href": "http://myspace.com/articles/in-memoriam",
        "external": false
      },
      {
        "text": "GALLERY",
        "href": "http://myspace.com/articles/gallery",
        "external": false
      },
      {
        "text": "20 QUESTIONS",
        "href": "http://myspace.com/articles/20-questions",
        "external": false
      },
      {
        "text": "#THROWBACKTHURSDAY",
        "href": "http://myspace.com/articles/throwback-thursday",
        "external": false
      },
      {
        "text": "WHAT YOU MISSED OVER THE WEEKEND",
        "href": "http://myspace.com/articles/what-you-missed-over-the-weekend",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t1568",
        "href": "http://myspace.com/article/2022/3/14/thom-yorke-surprise-releases-new-song-517",
        "external": false
      },
      {
        "text": "Thom Yorke Surprise-Releases New Song ‘5.17’",
        "href": "http://myspace.com/article/2022/3/14/thom-yorke-surprise-releases-new-song-517",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t1291",
        "href": "http://myspace.com/article/2022/3/14/behind-the-scenes-of-mothicas-newest-mental-health-based-track-sensitive",
        "external": false
      },
      {
        "text": "Behind the Scenes of Mothica’s Newest Mental Health-Based Track, ‘Sensitive’",
        "href": "http://myspace.com/article/2022/3/14/behind-the-scenes-of-mothicas-newest-mental-health-based-track-sensitive",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t618",
        "href": "http://myspace.com/article/2022/3/14/dolly-parton-respectfully-bows-out-of-rock-hall-nomination",
        "external": false
      },
      {
        "text": "Dolly Parton ‘Respectfully Bows Out’ of Rock Hall Nomination",
        "href": "http://myspace.com/article/2022/3/14/dolly-parton-respectfully-bows-out-of-rock-hall-nomination",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t263",
        "href": "http://myspace.com/article/2022/3/14/bikini-kill-detail-2022-summer-tour",
        "external": false
      },
      {
        "text": "Bikini Kill Detail 2022 Summer Tour",
        "href": "http://myspace.com/article/2022/3/14/bikini-kill-detail-2022-summer-tour",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t1346",
        "href": "http://myspace.com/article/2022/3/14/yeah-yeah-yeahs-tease-first-new-music-in-more-than-nine-years",
        "external": false
      },
      {
        "text": "Yeah Yeah Yeahs Tease First New Music in More Than Nine Years",
        "href": "http://myspace.com/article/2022/3/14/yeah-yeah-yeahs-tease-first-new-music-in-more-than-nine-years",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t313",
        "href": "http://myspace.com/article/2022/3/14/the-rolling-stones-announce-60th-anniversary-tour",
        "external": false
      },
      {
        "text": "The Rolling Stones Announce 60th Anniversary Tour",
        "href": "http://myspace.com/article/2022/3/14/the-rolling-stones-announce-60th-anniversary-tour",
        "external": false
      },
      {
        "text": "Sign Up Today",
        "href": "http://myspace.com/signup",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t512",
        "href": "http://myspace.com/article/2022/3/11/yungblud-shares-the-funeral-video-with-ozzy-and-sharon-osbourne-cameo-spin",
        "external": false
      },
      {
        "text": "Yungblud Shares ‘The Funeral’ Video With Ozzy and Sharon Osbourne Cameo",
        "href": "http://myspace.com/article/2022/3/11/yungblud-shares-the-funeral-video-with-ozzy-and-sharon-osbourne-cameo-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t302",
        "href": "http://myspace.com/article/2022/3/11/flea-joins-nick-cave-and-warren-for-performance-of-we-no-who-u-r-spin",
        "external": false
      },
      {
        "text": "Flea Joins Nick Cave and Warren for Performance of ‘We No Who U R’",
        "href": "http://myspace.com/article/2022/3/11/flea-joins-nick-cave-and-warren-for-performance-of-we-no-who-u-r-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t410",
        "href": "http://myspace.com/article/2022/3/11/george-rr-martin-gives-update-on-game-of-thrones-spin-offs-nme",
        "external": false
      },
      {
        "text": "George R.R. Martin gives update on ‘Game Of Thrones’ spin-offs",
        "href": "http://myspace.com/article/2022/3/11/george-rr-martin-gives-update-on-game-of-thrones-spin-offs-nme",
        "external": false
      },
      {
        "text": "IN MEMORIAM\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t285",
        "href": "http://myspace.com/article/2022/3/11/mike-cross-founding-guitarist-of-sponge-dies-at-57-spin",
        "external": false
      },
      {
        "text": "Mike Cross, Founding Guitarist of Sponge, Dies at 57",
        "href": "http://myspace.com/article/2022/3/11/mike-cross-founding-guitarist-of-sponge-dies-at-57-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t146",
        "href": "http://myspace.com/article/2022/3/10/black-keys-announce-11th-studio-album-dropout-boogie-share-wild-child-spin",
        "external": false
      },
      {
        "text": "Black Keys Announce 11th Studio Album Dropout Boogie, Share ‘Wild Child’",
        "href": "http://myspace.com/article/2022/3/10/black-keys-announce-11th-studio-album-dropout-boogie-share-wild-child-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t172",
        "href": "http://myspace.com/article/2022/3/10/florence-the-machine-announce-dance-fever-release-my-love-spin",
        "external": false
      },
      {
        "text": "Florence + The Machine Announce Dance Fever, Release ‘My Love’",
        "href": "http://myspace.com/article/2022/3/10/florence-the-machine-announce-dance-fever-release-my-love-spin",
        "external": false
      },
      {
        "text": "",
        "href": "http://myspace.com/gettingnailed/video/too-short-getting-nailed/109608833",
        "external": false
      },
      {
        "text": "GETTING NAILED\n\t\t\t\t\t\tToo Short - Getting Nailed",
        "href": "http://myspace.com/gettingnailed/video/too-short-getting-nailed/109608833",
        "external": false
      },
      {
        "text": "",
        "href": "http://myspace.com/gettingnailed/video/too-short-getting-nailed/109608833",
        "external": false
      },
      {
        "text": "",
        "href": "http://myspace.com/myspace/video/the-pedicab-interviews-chris-cole/109546118",
        "external": false
      },
      {
        "text": "THE PEDICAB INTERVIEWS\n\t\t\t\t\t\tThe Pedicab Interviews: Chris Cole",
        "href": "http://myspace.com/myspace/video/the-pedicab-interviews-chris-cole/109546118",
        "external": false
      },
      {
        "text": "",
        "href": "http://myspace.com/myspace/video/the-pedicab-interviews-chris-cole/109546118",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t113",
        "href": "http://myspace.com/article/2022/3/10/how-mgmts-little-dark-age-became-an-unstoppable-tiktok-meme-spin",
        "external": false
      },
      {
        "text": "How MGMT’s ‘Little Dark Age’ Became an Unstoppable TikTok Meme",
        "href": "http://myspace.com/article/2022/3/10/how-mgmts-little-dark-age-became-an-unstoppable-tiktok-meme-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t82",
        "href": "http://myspace.com/article/2022/3/10/pavement-unveil-new-video-for-harness-your-hopes-spin",
        "external": false
      },
      {
        "text": "Pavement Unveil New Video for ‘Harness Your Hopes’",
        "href": "http://myspace.com/article/2022/3/10/pavement-unveil-new-video-for-harness-your-hopes-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t76",
        "href": "http://myspace.com/article/2022/3/9/the-nationals-new-album-has-a-classic-sound-with-a-lot-of-energy-nme",
        "external": false
      },
      {
        "text": "The National’s new album has a “classic” sound with “a lot of energy”",
        "href": "http://myspace.com/article/2022/3/9/the-nationals-new-album-has-a-classic-sound-with-a-lot-of-energy-nme",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t95",
        "href": "http://myspace.com/article/2022/3/9/bob-dylan-announces-first-new-book-in-18-years-spin",
        "external": false
      },
      {
        "text": "Bob Dylan Announces First New Book in 18 Years",
        "href": "http://myspace.com/article/2022/3/9/bob-dylan-announces-first-new-book-in-18-years-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t75",
        "href": "http://myspace.com/article/2022/3/9/the-muppets-series-about-electric-mayhem-band-in-the-works-nme",
        "external": false
      },
      {
        "text": "The Muppets series about Electric Mayhem Band in the works",
        "href": "http://myspace.com/article/2022/3/9/the-muppets-series-about-electric-mayhem-band-in-the-works-nme",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t62",
        "href": "http://myspace.com/article/2022/3/9/king-gizzard-and-the-lizard-wizard-tease-first-double-lp-with-18-minute-single-spin",
        "external": false
      },
      {
        "text": "King Gizzard and the Lizard Wizard Tease First Double LP With 18-Minute Single",
        "href": "http://myspace.com/article/2022/3/9/king-gizzard-and-the-lizard-wizard-tease-first-double-lp-with-18-minute-single-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t88",
        "href": "http://myspace.com/article/2022/3/8/alanis-morissette-details-jagged-little-pill-25th-anniversary-tour-spin",
        "external": false
      },
      {
        "text": "Alanis Morissette Details Jagged Little Pill 25th Anniversary Tour",
        "href": "http://myspace.com/article/2022/3/8/alanis-morissette-details-jagged-little-pill-25th-anniversary-tour-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t86",
        "href": "http://myspace.com/article/2022/3/8/blink-182s-travis-barker-is-developing-a-new-reality-tv-series-inked-and-iced-nme",
        "external": false
      },
      {
        "text": "Blink-182’s Travis Barker is developing a new reality TV series, ‘Inked And Iced’",
        "href": "http://myspace.com/article/2022/3/8/blink-182s-travis-barker-is-developing-a-new-reality-tv-series-inked-and-iced-nme",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t51",
        "href": "http://myspace.com/article/2022/3/8/john-doe-to-release-new-solo-album-spin",
        "external": false
      },
      {
        "text": "John Doe to Release New Solo Album",
        "href": "http://myspace.com/article/2022/3/8/john-doe-to-release-new-solo-album-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t99",
        "href": "http://myspace.com/article/2022/3/8/snoop-dogg-joins-esports-outfit-faze-clan-as-a-content-creator-nme",
        "external": false
      },
      {
        "text": "Snoop Dogg joins esports outfit Faze Clan as a content creator",
        "href": "http://myspace.com/article/2022/3/8/snoop-dogg-joins-esports-outfit-faze-clan-as-a-content-creator-nme",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t92",
        "href": "http://myspace.com/article/2022/3/8/the-weeknd-to-appear-on-upcoming-episode-of-the-simpsons-spin",
        "external": false
      },
      {
        "text": "The Weeknd to Appear on Upcoming Episode of The Simpsons",
        "href": "http://myspace.com/article/2022/3/8/the-weeknd-to-appear-on-upcoming-episode-of-the-simpsons-spin",
        "external": false
      },
      {
        "text": "NEWS\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\n\t\t\t\t\t40",
        "href": "http://myspace.com/article/2022/3/8/arcade-fire-continue-to-tease-new-material-with-sheet-music-and-postcards",
        "external": false
      }
    ],
    "maxLinksReached": false
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

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
# GlobalTaunt

GlobalTaunt is a C# client for the official [League of Legends API](https://developer.riotgames.com/).

![Teemo](http://i.imgur.com/xSgL0HW.jpg "Teemo")

## About

GlobalTaunt supports all available API endpoints - `champion`, `game`, `league`, `stats`, `summoner` and `team`. [RestSharp](http://restsharp.org/) is used under the hood and is the only dependency. I may switch to `HttpClient` in the future. Pull requests are entirely welcomed.

## Examples

For now, just take a look at the [unit tests](https://github.com/ryancole/GlobalTaunt/tree/master/GlobalTaunt.Test/Tests) for some basic examples.

## NuGet

GlobalTaunt is available on [NuGet](http://www.nuget.org/packages/GlobalTaunt/).

```
PM> Install-Package GlobalTaunt
```

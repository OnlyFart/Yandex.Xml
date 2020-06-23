# Yandex.Xml
[![NuGet version (Yandex.Xml)](https://img.shields.io/nuget/v/Yandex.Xml)](https://www.nuget.org/packages/Yandex.Xml/)

Using
```
var yandexXmlProvider = YandexXmlProviderFactory.Create();
            
// Input real data in ctor
var queryParams = new QueryParams("user", "key", "query", "213", SearchType.Com);

queryParams.Page = 1;
queryParams.I10n = I10n.English;
queryParams.Filter = Filter.None;
queryParams.GroupsOnPage = GroupsOnPage.Hundred;

var response = yandexXmlProvider.GetStringAsync(queryParams).Result;

Console.WriteLine(response);
Console.Read();
```

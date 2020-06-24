# Yandex.Xml
[![NuGet version (Yandex.Xml)](https://img.shields.io/nuget/v/Yandex.Xml)](https://www.nuget.org/packages/Yandex.Xml/)

Using
```
var yandexXmlClient = YandexXmlClientFactory.Create();
            
// Input real user and key in ctor
var queryParams = new QueryParams("<your_user>", "<your_key>") {
	Query = "test",
	Lr = "213",
	SearchType = SearchType.Com,
	Page = 1, 
	I10n = I10n.English, 
	Filter = Filter.None, 
	GroupsOnPage = GroupsOnPage.Hundred
};

using (var client = new HttpClient()) {
	var response = yandexXmlClient.GetParsedAsync(client, queryParams).Result;
	foreach (var yandexXmlItem in response.Items) {
		Console.WriteLine(yandexXmlItem.Url);
	}
}

Console.Read();
```

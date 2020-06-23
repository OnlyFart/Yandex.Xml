using System;
using Yandex.Xml;
using Yandex.Xml.Enums;
using Yandex.Xml.Types;

namespace Sample {
    class Program {
        static void Main(string[] args) {
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
        }
    }
}

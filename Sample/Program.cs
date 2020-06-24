﻿using System;
using System.Net.Http;
using Yandex.Xml;
using Yandex.Xml.Enums;
using Yandex.Xml.Types;

namespace Sample {
    class Program {
        static void Main(string[] args) {
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
        }
    }
}

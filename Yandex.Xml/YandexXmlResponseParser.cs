using System.Xml.Linq;
using Yandex.Xml.Types;

namespace Yandex.Xml {
    public class YandexXmlResponseParser {
        public static YandexXmlResponse Parse(string response) {
            var xml = XDocument.Parse(response);
            var responseElement = xml.Element("yandexsearch")?.Element("response");

            var result = new YandexXmlResponse();
            if (responseElement != null) {
                var error = responseElement.Element("error");
                if (error != null) {
                    result.ErrorCode = error.Attribute("code")?.Value;
                    result.ErrorMessage = error.Value;
                }
                
                foreach (var node in responseElement.Elements("found")) {
                    if (result.Found == 0 && node.Name == "found" && node.Attribute("priority")?.Value == "all") {
                        result.Found = long.Parse(node.Value);
                    }
                }

                var grouping = responseElement.Element("results")?.Element("grouping");
                if (grouping == null) {
                    return result;
                }
                
                foreach (var group in grouping.Elements("group")) {
                    var doc = group.Element("doc");
                    if (doc == null) {
                        continue;
                    }
                    
                    var url = (doc.Element("url")?.Value ?? string.Empty).Trim();
                    var title = (doc.Element("title")?.Value ?? string.Empty).Trim();
                    var headline = (doc.Element("headline")?.Value ?? string.Empty).Trim();
                    var domain = (doc.Element("domain")?.Value ?? string.Empty).Trim();
                            
                    result.Items.Add(new YandexXmlItem {
                        Url = url,
                        Title = title,
                        Domain = domain,
                        Headline = headline
                    });
                }
            }

            return result;
        }
    }
}

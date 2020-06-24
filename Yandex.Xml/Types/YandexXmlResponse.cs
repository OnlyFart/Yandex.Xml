using System.Collections.Generic;

namespace Yandex.Xml.Types {
    public class YandexXmlResponse {
        public long Found;
        public List<YandexXmlItem> Items = new List<YandexXmlItem>();
        public string ErrorCode;
        public string ErrorMessage;
    }
}

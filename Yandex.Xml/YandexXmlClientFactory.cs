using Yandex.Xml.Builders;
using Yandex.Xml.Interfaces;
using Yandex.Xml.Providers;

namespace Yandex.Xml {
    public static class YandexXmlClientFactory {
        public static YandexXmlClient Create() {
            return new YandexXmlClient(new DefaultQueryBuilder());
        }
        
        public static YandexXmlClient Create(IQueryBuilder queryBuilder) {
            return new YandexXmlClient(queryBuilder);
        }
    }
}

using Yandex.Xml.Builders;
using Yandex.Xml.Interfaces;
using Yandex.Xml.Provider;

namespace Yandex.Xml {
    public static class YandexXmlProviderFactory {
        public static YandexXmlProvider Create() {
            return new YandexXmlProvider(new DefaultHttpClientBuilder(), new DefaultQueryBuilder());
        }
        
        public static YandexXmlProvider Create(IHttpClientBuilder httpClientBuilder, IQueryBuilder queryBuilder) {
            return new YandexXmlProvider(httpClientBuilder, queryBuilder);
        }
    }
}

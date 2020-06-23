using System.Net;
using System.Net.Http;
using Yandex.Xml.Interfaces;

namespace Yandex.Xml.Builders {
    public class DefaultHttpClientBuilder : IHttpClientBuilder {
        public HttpClient Build() {
            return new HttpClient();
        }

        public HttpClient Build(WebProxy proxy) {
            return new HttpClient(new HttpClientHandler {Proxy = proxy});
        }
    }
}

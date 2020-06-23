using System.Net;
using System.Net.Http;
using Yandex.Xml.Interfaces;

namespace Yandex.Xml.Builders {
    /// <summary>
    /// Builder for HttpClient
    /// </summary>
    public class DefaultHttpClientBuilder : IHttpClientBuilder {
        /// <summary>
        /// Built HttpClient
        /// </summary>
        /// <returns></returns>
        public HttpClient Build() {
            return new HttpClient();
        }

        /// <summary>
        /// Built HttpClient with proxy
        /// </summary>
        /// <returns></returns>
        public HttpClient Build(WebProxy proxy) {
            return new HttpClient(new HttpClientHandler {Proxy = proxy});
        }
    }
}

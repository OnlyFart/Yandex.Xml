using System.Net;
using System.Net.Http;

namespace Yandex.Xml.Interfaces {
    public interface IHttpClientBuilder {
        /// <summary>
        /// Built HttpClient
        /// </summary>
        /// <returns></returns>
        HttpClient Build();
        
        /// <summary>
        /// Built HttpClient with proxy
        /// </summary>
        /// <returns></returns>
        HttpClient Build(WebProxy proxy);
    }
}

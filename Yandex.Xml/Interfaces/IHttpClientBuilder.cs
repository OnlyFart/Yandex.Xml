using System.Net;
using System.Net.Http;

namespace Yandex.Xml.Interfaces {
    public interface IHttpClientBuilder {
        HttpClient Build();
        
        HttpClient Build(WebProxy proxy);
    }
}

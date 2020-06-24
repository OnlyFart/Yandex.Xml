using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Yandex.Xml.Interfaces;
using Yandex.Xml.Types;

namespace Yandex.Xml.Providers {
    public class YandexXmlClient {
        private readonly IQueryBuilder _queryBuilder;

        public YandexXmlClient(IQueryBuilder queryBuilder) {
            _queryBuilder = queryBuilder;
        }

        /// <summary>
        /// Get string response from yandex.xml
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="queryParams">Parameters of request</param>
        /// <returns></returns>
        public async Task<string> GetStringAsync(HttpClient client, QueryParams queryParams) {
            return await client.GetStringAsync(_queryBuilder.Build(queryParams));
        }

        /// <summary>
        /// Get stream response from yandex.xml
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="queryParams">Parameters of request</param>
        /// <returns></returns>
        public async Task<Stream> GetStreamAsync(HttpClient client, QueryParams queryParams) {
            return await client.GetStreamAsync(_queryBuilder.Build(queryParams));
        }
        
        /// <summary>
        /// Get parsed response from yandex.xml
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="queryParams">Parameters of request</param>
        /// <returns></returns>
        public async Task<YandexXmlResponse> GetParsedAsync(HttpClient client, QueryParams queryParams) {
            return YandexXmlResponseParser.Parse(await GetStringAsync(client, queryParams));
        }
    }
}

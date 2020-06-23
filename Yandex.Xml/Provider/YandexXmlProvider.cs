using System.IO;
using System.Net;
using System.Threading.Tasks;
using Yandex.Xml.Interfaces;
using Yandex.Xml.Types;

namespace Yandex.Xml.Provider {
    public class YandexXmlProvider {
        private readonly IHttpClientBuilder _httpClientBuilder;
        private readonly IQueryBuilder _queryBuilder;

        public YandexXmlProvider(IHttpClientBuilder httpClientBuilder, IQueryBuilder queryBuilder) {
            _httpClientBuilder = httpClientBuilder;
            _queryBuilder = queryBuilder;
        }
        
        /// <summary>
        /// Get string response from yandex.xml via proxy
        /// </summary>
        /// <param name="queryParams">Parameters of request</param>
        /// <param name="proxy">Proxy</param>
        /// <returns></returns>
        public async Task<string> GetStringAsync(QueryParams queryParams, WebProxy proxy) {
            var url = _queryBuilder.Build(queryParams);

            using (var client = _httpClientBuilder.Build(proxy)) {
                return await client.GetStringAsync(url);
            }
        }
        
        /// <summary>
        /// Get stream response from yandex.xml via proxy
        /// </summary>
        /// <param name="queryParams">Parameters of request</param>
        /// <param name="proxy">Proxy</param>
        /// <returns></returns>
        public async Task<Stream> GetStreamAsync(QueryParams queryParams, WebProxy proxy) {
            var url = _queryBuilder.Build(queryParams);

            using (var client = _httpClientBuilder.Build(proxy)) {
                return await client.GetStreamAsync(url);
            }
        }
        
        /// <summary>
        /// Get string response from yandex.xml
        /// </summary>
        /// <param name="queryParams">Parameters of request</param>
        /// <returns></returns>
        public async Task<string> GetStringAsync(QueryParams queryParams) {
            var url = _queryBuilder.Build(queryParams);

            using (var client = _httpClientBuilder.Build()) {
                return await client.GetStringAsync(url);
            }
        }
        
        /// <summary>
        /// Get stream response from yandex.xml
        /// </summary>
        /// <param name="queryParams">Parameters of request</param>
        /// <returns></returns>
        public async Task<Stream> GetStreamAsync(QueryParams queryParams) {
            var url = _queryBuilder.Build(queryParams);

            using (var client = _httpClientBuilder.Build()) {
                return await client.GetStreamAsync(url);
            }
        }
    }
}

using System.Text;
using System.Web;
using Yandex.Xml.Enums;
using Yandex.Xml.Extensions;
using Yandex.Xml.Interfaces;
using Yandex.Xml.Types;

namespace Yandex.Xml.Builders {
    /// <summary>
    /// Builder for queryparams
    /// </summary>
    public class DefaultQueryBuilder : IQueryBuilder {
        /// <summary>
        /// Built queryparams to url
        /// </summary>
        /// <param name="queryParams"></param>
        /// <returns></returns>
        public string Build(QueryParams queryParams) {
            var sb = new StringBuilder($"https://yandex.{queryParams.SearchType.GetDescription()}/search/xml?");
            sb.Append($"user={queryParams.User}&");
            sb.Append($"key={queryParams.Key}&");
            sb.Append($"query={HttpUtility.UrlEncode(queryParams.Query)}&");
            sb.Append($"lr={queryParams.Lr}&");
            sb.Append($"l10n={queryParams.I10n.GetDescription()}&");
            sb.Append($"sortby={queryParams.SortBy.GetDescription()}&");
            sb.Append($"filter={queryParams.Filter.GetDescription()}&");

            if (queryParams.MaxPassages != MaxPassages.None) {
                sb.Append($"maxpassages={queryParams.MaxPassages.GetDescription()}&");
            }
            
            sb.Append($"groupby={queryParams.GroupBy.GetDescription()}.{queryParams.GroupsOnPage.GetDescription()}.{queryParams.DocsInGroup.GetDescription()}&");
            sb.Append($"page={queryParams.Page}");
            
            return sb.ToString();
        }
    }
}

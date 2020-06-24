using Yandex.Xml.Enums;

namespace Yandex.Xml.Types {
    /// <summary>
    /// Parameters of yandex.xml request <see cref="https://xml.yandex.ru/test/"/>
    /// </summary>
    public class QueryParams {
        public QueryParams(string user, string key) {
            User = user;
            Key = key;
        }
        
        /// <summary>
        /// User value
        /// </summary>
        public string User;
        
        /// <summary>
        /// Key value
        /// </summary>
        public string Key;
        
        /// <summary>
        /// Query value
        /// </summary>
        public string Query;
        
        /// <summary>
        /// Lr value
        /// </summary>
        public string Lr;
        
        /// <summary>
        /// Page number
        /// </summary>
        public int Page;
        
        /// <summary>
        /// SearchType
        /// </summary>
        public SearchType SearchType;
        
        /// <summary>
        /// Language
        /// </summary>
        public I10n I10n;
        
        /// <summary>
        /// SortBy
        /// </summary>
        public SortBy SortBy;
        
        /// <summary>
        /// Filter
        /// </summary>
        public Filter Filter;
        
        /// <summary>
        /// MaxPassages
        /// </summary>
        public MaxPassages MaxPassages;
        
        /// <summary>
        /// GroupBy
        /// </summary>
        public GroupBy GroupBy;
        
        /// <summary>
        /// GroupsOnPage
        /// </summary>
        public GroupsOnPage GroupsOnPage;
        
        /// <summary>
        /// DocsInGroup
        /// </summary>
        public DocsInGroup DocsInGroup;
    }
}

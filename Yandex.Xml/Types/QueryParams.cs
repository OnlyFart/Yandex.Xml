using Yandex.Xml.Enums;

namespace Yandex.Xml.Types {
    public class QueryParams {
        public QueryParams(string user, string key, string query, string lr, SearchType searchType) {
            User = user;
            Key = key;
            Query = query;
            Lr = lr;
            SearchType = searchType;
        }
        
        public string User;

        public string Key;

        public string Query;

        public string Lr;

        public int Page;
        
        public SearchType SearchType;
        
        public I10n I10n;

        public SortBy SortBy;

        public Filter Filter;

        public MaxPassages MaxPassages;

        public GroupBy GroupBy;

        public GroupsOnPage GroupsOnPage;

        public DocsInGroup DocsInGroup;
    }
}

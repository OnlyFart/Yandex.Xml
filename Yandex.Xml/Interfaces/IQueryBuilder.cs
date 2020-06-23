using Yandex.Xml.Types;

namespace Yandex.Xml.Interfaces {
    public interface IQueryBuilder {
        string Build(QueryParams queryParams);
    }
}

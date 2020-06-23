using Yandex.Xml.Types;

namespace Yandex.Xml.Interfaces {
    /// <summary>
    /// Builder for queryparams
    /// </summary>
    public interface IQueryBuilder {
        /// <summary>
        /// Built queryparams to url
        /// </summary>
        /// <param name="queryParams"></param>
        /// <returns></returns>
        string Build(QueryParams queryParams);
    }
}

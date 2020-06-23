using System.ComponentModel;

namespace Yandex.Xml.Enums {
    public enum SortBy {
        /// <summary>
        /// By appointment time. Direction asc
        /// </summary>
        [Description("tm.order%3Dascending")]
        TmOrderAsc,
        
        /// <summary>
        /// By appointment time. Direction desc
        /// </summary>
        [Description("tm.order%3Ddescending")]
        TmOrderDesc,
        
        /// <summary>
        /// By relevation
        /// </summary>
        [Description("rlv")]
        Rlv
    }
}

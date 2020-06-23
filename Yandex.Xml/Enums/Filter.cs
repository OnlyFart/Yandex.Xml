using System.ComponentModel;

namespace Yandex.Xml.Enums {
    public enum Filter {
        /// <summary>
        /// Strict
        /// </summary>
        [Description("strict")]
        Strict,
        
        /// <summary>
        /// Moderate
        /// </summary>
        [Description("moderate")]
        Moderate,
        
        /// <summary>
        /// None
        /// </summary>
        [Description("none")]
        None
    }
}

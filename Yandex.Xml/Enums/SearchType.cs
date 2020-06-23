using System.ComponentModel;

namespace Yandex.Xml.Enums {
    /// <summary>
    /// Search type
    /// </summary>
    public enum SearchType {
        /// <summary>
        /// Russian
        /// </summary>
        [Description("ru")]
        Ru,
        
        /// <summary>
        /// English
        /// </summary>
        [Description("com")]
        Com,
        
        /// <summary>
        /// Turkish
        /// </summary>
        [Description("com.tr")]
        Tr,
    }
}

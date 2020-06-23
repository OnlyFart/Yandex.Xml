using System.ComponentModel;

namespace Yandex.Xml.Enums {
    public enum GroupBy {
        /// <summary>
        /// Deep
        /// </summary>
        [Description("attr%3Dd.mode%3Ddeep")]
        Deep,
        
        /// <summary>
        /// Flat
        /// </summary>
        [Description("attr%3D%22%22.mode%3Dflat")]
        Flat
    }
}

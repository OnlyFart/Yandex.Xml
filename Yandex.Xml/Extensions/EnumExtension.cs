using System;
using System.ComponentModel;
using System.Linq;

namespace Yandex.Xml.Extensions {
    public static class EnumExtension {
        /// <summary>
        /// Get description attribute
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value) {
            var customAttributes = (DescriptionAttribute[]) value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false);
            return customAttributes.Any() ? customAttributes[0].Description : value.ToString();
        }
    }
}

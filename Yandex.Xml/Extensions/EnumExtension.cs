using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Yandex.Xml.Extensions {
    public static class EnumExtension {
        public static string GetDescription(this Enum value) {
            var customAttributes = (DescriptionAttribute[]) value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false);
            return customAttributes.Any() ? customAttributes[0].Description : value.ToString();
        }
    }
}

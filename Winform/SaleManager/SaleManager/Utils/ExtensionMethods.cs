using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Utils
{
    static class ExtensionMethods
    {
        public static int ToInt(this string number) => int.TryParse(number, out int i) ? i : -1;
        public static string ToCurrentcy(this int number)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return number.ToString("#,###", cul.NumberFormat);
        }
        public static string ToCurrentcy(this string number)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return number.ToInt().ToString("#,###", cul.NumberFormat);
        }
        public static int CurrentcyToNumber(this string currency)
        {
            var result = currency.Replace(",", "");
            result = result.Replace(".", "");
            result = result.Trim();
            if (result.IsNumberic())
                return result.ToInt();
            return 0;
        }
        public static bool IsNumberic(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            return str.ToCharArray().All(x => Char.IsDigit(x) || x.Equals("."));
        }
        public static string ToStringOrEmpty(this object val)
        {
            return val == null ? null : val.ToString();
        }
    }
}

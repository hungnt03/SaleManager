using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Utils
{
    public static class StringUtil
    {
        public static string ToCurrentcy(int num)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
           return num.ToString("#,###", cul.NumberFormat);
        }

        public static int ConvertCurrentcy(string currency)
        {
            var result = currency.Replace(",", "");
            result = result.Replace(".", "");
            result = result.Trim();
            if (IsNumberic(result))
                return int.Parse(result);
            return 0;
        }

        public static bool IsNumberic(string str)
        {
            return str.ToCharArray().All(x => Char.IsDigit(x));
        }
    }
}

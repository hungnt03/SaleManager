using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Utils
{
    public static class Constants
    {
        public static int PURCHASE = 0;
        public static int SELL = 1;
        public static bool PAID = true;
        public static bool NOT_PAY = false;
        public static int INSERT = 1;
        public static int UPDATE = 2;
        public static string ROOT_PATH = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public const int CP_NOCLOSE_BUTTON = 0x200;
    }
}

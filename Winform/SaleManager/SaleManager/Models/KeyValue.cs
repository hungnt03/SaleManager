using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class KeyValue
    {
        public string key { set; get; }
        public string value { set; get; }

        public KeyValue()
        {

        }

        public KeyValue(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}

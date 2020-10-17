using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.Models
{
    public class MainModel
    {
        public MainModel()
        {
            products = new List<BillProductModel>();
            binding = new BindingList<BillProductModel>(products);
            source = new BindingSource(binding, null);
        }
        public int id { set; get; }
        public List<BillProductModel> products { set; get; }

        private BindingList<BillProductModel> binding;
        public BindingSource source { get; }
        public string note { set; get; }
        public string _total;
        public string total { 
            set 
            {
                if(StringUtil.IsNumberic(value))
                    this._total = value.Replace(".", string.Empty);
                if (!StringUtil.IsNumberic(value))
                    this._total = "0";
            }
            get 
            { return StringUtil.ToCurrentcy(int.Parse(_total)); }
        }

        public string _moneyCustomer;
        public string moneyCustomer
        {
            set
            {
                if (StringUtil.IsNumberic(value))
                    this._moneyCustomer = value.Replace(".",string.Empty);
                if (!StringUtil.IsNumberic(value))
                    this._moneyCustomer = "0";
            }
            get
            { return StringUtil.ToCurrentcy(int.Parse(_moneyCustomer)); }
        }

        public string _moneyChange;
        public string moneyChange
        {
            set
            {
                if (StringUtil.IsNumberic(value))
                    this._moneyChange = value.Replace(".", string.Empty);
                if (!StringUtil.IsNumberic(value))
                    this._moneyChange = "0";
            }
            get
            { return StringUtil.ToCurrentcy(int.Parse(_moneyChange)); }
        }
        public void Refesh()
        {
            binding.ResetBindings();
            source.ResetBindings(false);
        }

        public string GetTotal()
        {
            var result = 0;
            if (products.Count == 0)
                return result.ToString();
            foreach(var product in products)
            {
                result += StringUtil.ConvertCurrentcy(product.total);
            }
            return StringUtil.ToCurrentcy(result);
        }
    }
}

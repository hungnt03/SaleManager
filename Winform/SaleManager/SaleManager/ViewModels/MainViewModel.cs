using SaleManager.Services;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class MainViewModel
    {
        private MainService _service;
        public BindingSource _productSource { set; get; }
        public BindingSource _unitSource { set; get; }
        public BindingSource _billSource { set; get; }
        public MainViewModel()
        {
            _service = new MainService();
        }
        public void Load()
        {
            _productSource.ResetBindings(false);
            _productSource.DataSource = _service.GetPinProducts();
            //_unitSource.ResetBindings(false);
            //_unitSource.DataSource = _service._db.Units.ToList();
           
        }
    }
}

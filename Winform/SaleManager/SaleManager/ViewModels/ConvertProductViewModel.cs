using SaleManager.Models;
using SaleManager.Services;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class ConvertProductViewModel
    {
        private ConvertProductService _service;
        public BindingSource _source { set; get; }
        public BindingSource _productSource1 { set; get; }
        public BindingSource _productSource2 { set; get; }
        public ConvertProductViewModel()
        {
            _service = new ConvertProductService();
        }
        public void Load()
        {
            _source.ResetBindings(false);
            var convert = new ConvertProductModel()
            {
                Quantity1 = 1,
                Quantity2 = 0
            };
            _source.DataSource = convert;
            _productSource1.DataSource = _service.GetProducts();
            _productSource2.DataSource = _service.GetProducts();
        }
        public void Convert()
        {
            if(_source.DataSource is ConvertProductModel c)
            {
                c.Quantity2 = _service.Convert(c.Barcode1, c.Quantity1, c.Barcode2);
            }
        }
    }
}

using SaleManager.Models;
using SaleManager.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class BarcodeViewModel
    {
        private BarcodeService _service;
        public BindingSource _source { set; get; }
        public BarcodeViewModel()
        {
            _service = new BarcodeService();
        }
        public void Load()
        {
            _source.ResetBindings(false);
            _source.DataSource = _service.GetAll();
        }
        public void Export()
        {
            if(_source.DataSource is List<BarcodeModel> bs)
            {
                BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                var checkedList = bs.FindAll(x => x.IsChecked);
                foreach(var elm in checkedList)
                {
                    elm.BarcodeImg = b.Encode(BarcodeLib.TYPE.EAN13, elm.Barcode, Color.Black, Color.White, 160, 60);
                }
                _service.Export(checkedList);
            }
        }
    }
}

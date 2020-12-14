using SaleManager.Models;
using SaleManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class ConvertMasterViewModel
    {
        private ConvertMasterService _service;
        public BindingSource _convertSource { set; get; }
        public ConvertMasterViewModel()
        {
            _service = new ConvertMasterService();
        }
        public void Load()
        {
            _convertSource.ResetBindings(false);
            _convertSource.DataSource = _service.GetAll();
        }
        public void Save()
        {
            if (_convertSource.DataSource is List<ConvertMasterModel> c)
            {
                //Valid
                if(c.Where(x=>!string.IsNullOrEmpty(x.Error)).FirstOrDefault() != null) {
                    MessageBox.Show("Dữ liệu chưa đúng, mời nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _service.Save(c);
            }
        }
        public void AddRow()
        {
            if(_convertSource.DataSource is List<ConvertMasterModel> c)
            {
                if (c.Find(x => x.Barcode1.Length != 13 || string.IsNullOrEmpty(x.Name1)) != null) return;
                c.Add(new ConvertMasterModel()
                {
                    Barcode1 = string.Empty,
                    Name1 = string.Empty,
                    Quantity1 = 1,
                    Barcode2 = string.Empty,
                    Name2 = string.Empty,
                    Quantity2 = 1
                }) ;
                _convertSource.ResetBindings(false);
            }
        }
    }
}

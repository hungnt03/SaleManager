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
    public class ConvertProductViewModel
    {
        private ConvertService _service;
        public BindingSource _convertSource { set; get; }
        public BindingSource _unitSource { set; get; }
        public ConvertProductViewModel()
        {
            _service = new ConvertService();
        }
        public void Load()
        {
            _convertSource.ResetBindings(false);
            _convertSource.DataSource = _service.GetAll();
            _unitSource.ResetBindings(false);
            _unitSource.DataSource = _service._db.Units.ToList();
        }
        public void Save()
        {
            if (_convertSource.DataSource is List<ConvertModel> c)
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
            if(_convertSource.DataSource is List<ConvertModel> c)
            {
                if (c.Find(x => x.Barcode.Length != 13 || string.IsNullOrEmpty(x.Name)) != null) return;
                var defaultUnit = _service._db.Units.First().Id;
                c.Add(new ConvertModel()
                {
                    Barcode = string.Empty,
                    Name = string.Empty,
                    Quantity1 = 1,
                    Quantity2 = 1,
                    Unit1 = defaultUnit,
                    Unit2 = defaultUnit
                }) ;
                _convertSource.ResetBindings(false);
            }
        }
    }
}

using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class ImportProductViewModel : INotifyPropertyChanged
    {
        private ImportProductService _service;

        public event PropertyChangedEventHandler PropertyChanged;
        public BindingSource _source { set; get; }
        public BindingSource _unitSource { set; get; }
        public BindingSource _supplierSource { set; get; }
        public string Title
        {
            get 
            { 
                if (_source.Current == null) 
                    return "Import"; 
                return $"Import - {(_source?.Current as ImportProductModel)?.ProductName}"; 
            }
        }
        public ImportProductViewModel()
        {
            _service = new ImportProductService();
        }

        public void Load()
        {
            _unitSource.ResetBindings(false);
            _unitSource.DataSource = _service._db.Units.ToList();
            _supplierSource.ResetBindings(false);
            _supplierSource.DataSource = _service._db.Suppliers.ToList();
        }

        public void Initialize() { 
            _source.CurrentChanged += delegate { Notify("Title"); };
        }

        public void Import(string filePath)
        {
            List<ImportProductModel> datas = _service.Read(filePath);
            _source.ResetBindings(false);
            _source.DataSource = datas;
        }

        public void Save()
        {            
            if(_source.DataSource is List<ImportProductModel> datas)
                _service.Save(datas);            
        }

        private void Notify([CallerMemberName] string property = "") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); 
        }
    }
}

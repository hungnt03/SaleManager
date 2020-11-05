using SaleManager.Controls;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            _productSource.DataSource = new ObservableCollection<CardViewModel>(_service.GetPinProducts());
            _unitSource.ResetBindings(false);
            _unitSource.DataSource = _service._db.Units.ToList();
            _billSource.ResetBindings(false);
            _billSource.DataSource = new List<BillProductModel>();
        }
        public void CardSelected(object sender, EventArgs e)
        {
            if (sender == null) return;
            if (((Control)sender).Parent is CardControl c)
            {
                var data = c._model;
                AddBillProduct(_service._db.Products.Find(data.Barcode, data.Unit));
            }
        }
        public void Search(string key)
        {
            if (key.Length != 13) return;
            AddBillProduct(_service.SearchBillProduct(key));
        }

        private void AddBillProduct(BillProductModel product)
        {
            if (product == null) return;
            if (_billSource.DataSource is List<BillProductModel> b)
            {
                var bill = b.Find(x => x.Barcode.Equals(product.Barcode) && x.Unit == product.Unit);
                if (bill == null)
                    b.Add(product);
                else
                    bill.Quantity += 1;
                _billSource.ResetBindings(false);
                _billSource.DataSource = b;
            }
        }
        private void AddBillProduct(Product product)
        {
            if (product == null) return;
            if (_billSource.DataSource is List<BillProductModel> b)
            {
                var bill = b.Find(x => x.Barcode.Equals(product.Barcode) && x.Unit == product.Unit);
                if (bill == null)
                    b.Add(new BillProductModel(product));
                else
                    bill.Quantity += 1;
                _billSource.ResetBindings(false);
                _billSource.DataSource = b;
            }
        }

    }
}

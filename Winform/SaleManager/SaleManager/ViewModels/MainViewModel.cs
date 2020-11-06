using SaleManager.Controls;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SaleManager.ViewModels
{
    public class MainViewModel
    {
        private MainService _service;
        public BindingSource _productSource { set; get; }
        public BindingSource _unitSource { set; get; }
        public BindingSource _billSource { set; get; }
        public BindingSource _mainSource { set; get; }
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
            _mainSource.ResetBindings(false);
            _mainSource.DataSource = new MainModel();
            _billSource.CurrentItemChanged += delegate { CalcTotal(); };
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
        public void SearchBillProduct(string key)
        {
            if (key.Length != 13) return;
            AddBillProduct(_service.SearchBillProduct(key));
        }

        public void SearchProduct(string key)
        {
            if (string.IsNullOrEmpty(key))
                _productSource.DataSource = new ObservableCollection<CardViewModel>(_service.GetPinProducts());
            else
                _productSource.DataSource = new ObservableCollection<CardViewModel>(_service.SearchProduct(key));
            _productSource.ResetBindings(false);
        }

        public void GridButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (!new List<string>() { "QuantityUp", "QuantityDown", "Del" }.Contains(dgv.Columns[e.ColumnIndex].DataPropertyName)) return;
            var barcode = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();//Barcode
            var unit = dgv.Rows[e.RowIndex].Cells[6].Value.ToString().ToInt();//Unit
            if (_billSource.DataSource is List<BillProductModel> b)
            {                
                var product = b.Find(x => x.Barcode.Equals(barcode) && x.Unit == unit);
                if (product == null) return;
                //QuantityUp click
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "QuantityUp")
                    product.Quantity += 1;
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "QuantityDown")
                {
                    if (product.Quantity < 2) return;
                    product.Quantity -= 1;
                }
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Del")
                    b.Remove(product);
                _billSource.ResetBindings(false);
            }
        }
        public void Pay()
        {

        }
        public void ClearPayment()
        {
            if (_mainSource.DataSource is MainModel m) m.Payment = 0;
        }
        private void CalcTotal()
        {
            if (_billSource.DataSource is List<BillProductModel> b)
            {
                if (b.Count == 0) return;
                var total = b.Sum(x=>x.Total);
                if (_mainSource.DataSource is MainModel m) m.Total = total;
            }
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

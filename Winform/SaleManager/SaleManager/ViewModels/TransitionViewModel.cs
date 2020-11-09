using SaleManager.Models;
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
    public class TransitionViewModel
    {
        private TransactionService _service;
        public BindingSource _source { set; get; }
        public BindingSource _supplierSource { set; get; }
        public TransitionViewModel()
        {
            _service = new TransactionService();
        }
        public void Load()
        {
            _source.ResetBindings(false);
            _source.DataSource = _service.GetAll();
            _supplierSource.DataSource = _service._db.Suppliers.ToList();
        }
        public void Search(bool isPayment, string key, string type, bool enableDate, DateTime from, DateTime to)
        {
            DateTime conditionFrom = enableDate ? from : DateTime.MinValue;
            DateTime conditionTo = enableDate ? to : DateTime.MinValue;
            int conditionType = !string.IsNullOrEmpty(type) && type.Equals("Bán hàng") ? Constants.SELL : Constants.PURCHASE;
            if (string.IsNullOrEmpty(type)) conditionType = -1;
            _source.DataSource = _source.DataSource = _service.Search(isPayment, key, conditionType, conditionFrom, conditionTo);
            _source.ResetBindings(false);
        }
        public void Save()
        {
            if(_source.DataSource is List<TransactionModel> trans)
            {
                if (MessageUtil.InformationConfirm("Để dữ liệu chính xác, hãy kiểm tra lại các giao dịch một lượt."+ 
                    System.Environment.NewLine +"Bạn có muốn lưu ? ") == DialogResult.No) return;
                if (_service.Save(trans))
                    MessageUtil.UpdateSuccess();
                else
                    MessageUtil.UpdateFailed();
            }
        }
    }
}

using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class TransactionDetailViewModel
    {
        private TransactionDetailService _service;
        public BindingSource _source { set; get; }
        public BindingSource _unitDetailSource { set; get; }
        public BindingSource _unitListSource { set; get; }
        public TransactionDetailViewModel()
        {
            _service = new TransactionDetailService();
        }
        public void Load(int id)
        {
            _source.ResetBindings(false);
            _source.DataSource = _service.FindById(id);
            _unitDetailSource.DataSource = _service._db.Units.ToList();
            _unitListSource.DataSource = _service._db.Units.ToList();
        }
        public void Delete()
        {
            if(_source.Current is TransactionDetailModel model)
            {
                if (MessageUtil.InformationConfirm("Bạn muốn xoá dữ liệu này?") == DialogResult.No) return;
                _service.Delete(model.Id, model.Barcode);
                _source.DataSource = _service.FindById(model.Id);
            }
        }
        public void Save()
        {

        }
    }
}

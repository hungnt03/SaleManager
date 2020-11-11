using SaleManager.Models;
using SaleManager.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class TransactionDetailViewModel
    {
        private TransactionDetailService _service;
        public BindingSource _source { set; get; }
        public BindingSource _unitSource { set; get; }
        public TransactionDetailViewModel()
        {
            _service = new TransactionDetailService();
        }
        public void Load(int id)
        {
            _source.ResetBindings(false);
            _source.DataSource = _service.FindById(id);
            _unitSource.DataSource = _service._db.Units.ToList();
        }
        public void Delete()
        {
            if(_source.Current is TransactionDetailModel model)
                ((List<TransactionDetailModel>)_source.DataSource).Remove(model);
        }
        public void Save()
        {

        }
    }
}

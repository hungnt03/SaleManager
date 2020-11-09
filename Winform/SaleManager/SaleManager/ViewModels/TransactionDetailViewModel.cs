using SaleManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void Delete(string barcode, int unit)
        {
            if(_source.DataSource is List<TransactionDetail> trans)
        }
    }
}

using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class SupplierViewModel
    {
        private SupplierService _service;
        public BindingSource _source { set; get; }
        public SupplierViewModel()
        {
            _service = new SupplierService();
        }
        public void Load()
        {
            _source.ResetBindings(false);
            _source.DataSource = _service.GetSuppliers();
        }
        public void Save()
        {
            if (_source.DataSource is List<SupplierModel> sources)
            {
                var suppliers = Mapper.Map<List<SupplierModel>, List<Supplier>>(sources);
                _service.Save(suppliers);
            }
        }
        public void Delete()
        {
            if(_source.Current is SupplierModel source)
            {
                if (MessageUtil.InformationConfirm("Bạn muốn xoá " + source.Name + " không?") == DialogResult.No) return;
                var supplier = Mapper.Map<SupplierModel, Supplier>(source);
                _service.Delete(supplier.Id);
            }
            _source.DataSource = _service.GetSuppliers();
        }
    }
}

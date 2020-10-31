using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.ViewModels
{
    public class ProductViewModel
    {
        private ProductService _service;
        public BindingSource _source { set; get; }
        public BindingSource _unitSource { set; get; }
        public BindingSource _supplierSource { set; get; }
        public BindingSource _categorySource { set; get; }
        public ProductViewModel()
        {
            _service = new ProductService();
        }
        public void Load()
        {
            _source.ResetBindings(false);
            _source.DataSource = Mapper.Map<List<Product>, List<ProductModel>>(_service.GetAll());
            _unitSource.ResetBindings(false);
            _unitSource.DataSource = _service._db.Units.ToList();
            _supplierSource.ResetBindings(false);
            var suppliers = _service._db.Suppliers.ToList();
            suppliers.Insert(0, new Supplier() { Id = -1, Name = "" });
            _supplierSource.DataSource = suppliers;
            _categorySource.ResetBindings(false);
            var categories = _service._db.Categories.ToList();
            categories.Insert(0, new Category() { Id = -1, Name = "" });
            _categorySource.DataSource = categories;
        }
        public void Search(string key)
        {
            _categorySource.ResetBindings(false);
            _source.DataSource = Mapper.Map<IList<Product>, IList<ProductModel>>(_service.Search(key));
        }
        public void AddImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    if (filePath.Length == 0)
                        return;
                    if (_source.Current is ProductModel p)
                    {
                        p.Img = filePath;
                        p.Image = _service.ResizeImage(Image.FromFile(filePath), 200, 200);
                    }
                }
            }
        }
        public void Save()
        {
            if(_source.DataSource is List<ProductModel> ps) _service.Save(ps);
        }
        public void Add()
        {

        }
    }
}

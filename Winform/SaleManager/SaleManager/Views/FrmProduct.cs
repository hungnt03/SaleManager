using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace SaleManager.Views
{
    public partial class FrmProduct : Form
    {
        private string _barcode;
        private ProductModel _product;
        private BindingSource _source;
        private ProductService _service;
        public FrmProduct(string barcode)
        {
            InitializeComponent();
            this._barcode = barcode;
            _service = new ProductService();
            _product = new ProductModel();
            _source = new BindingSource();
            InitView();
            InitBinding();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        }

        #region "Init"
        public void InitBinding()
        {
            txtBarcode.DataBindings.Add("text", _source, "Barcode");
            txtName.DataBindings.Add("text", _source, "Name");
            txtPrice.DataBindings.Add("text", _source, "Price");
            cmbCategory.DataBindings.Add("SelectedValue", _source, "CategoryId");
            cmbSupplier.DataBindings.Add("SelectedValue", _source, "SupplierId");
            txtQuality.DataBindings.Add("text", _source, "Quantity");
            txtUnit.DataBindings.Add("text", _source, "Unit");
            dtpEx.DataBindings.Add("Value", _source, "ExpirationDate");
            ckbPin.DataBindings.Add("Checked", _source, "Pin");
            ckbEnable.DataBindings.Add("Checked", _source, "Enable");
            txtPath.DataBindings.Add("text", _source, "Img");
        }

        public void InitView()
        {
            var source = new AutoCompleteStringCollection();
            var categoryBinding = new BindingSource();
            var categories = _service.GetCategoryList();
            categories.Insert(0, new KeyValue("-1", string.Empty));
            _product.Categories = categories;
            categoryBinding.DataSource = categories;
            cmbCategory.DataSource = categoryBinding;
            cmbCategory.DisplayMember = "Value";
            cmbCategory.ValueMember = "Key";

            var supplierBinding = new BindingSource();
            var suppliers = _service.GetSupplierList();
            suppliers.Insert(0, new KeyValue("-1", string.Empty));
            _product.Suppliers = suppliers;
            supplierBinding.DataSource = suppliers;
            cmbSupplier.DataSource = supplierBinding;
            cmbSupplier.DisplayMember = "Value";
            cmbSupplier.ValueMember = "Key";

            if (!string.IsNullOrEmpty(_barcode))
            {
                var product = _service.GetById(_barcode);
                _product = Mapper.Map<Product, ProductModel>(product);
                _product.Categories = categories;
                _product.Suppliers = suppliers;
                txtBarcode.ReadOnly = true;
                var imgRootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\";
                if (new FileInfo(imgRootPath + product.Img).Exists)
                    ptbImage.Image = new Bitmap(Image.FromFile(imgRootPath + product.Img));
            }
            else
                btnDelete.Enabled = false;
            _source.DataSource = _product;
            _source.ResetBindings(false);
            
        }
        #endregion

        #region "Event"
        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                if (filePath.Length == 0)
                    return;
                txtPath.Text = filePath;
                var imgResized = _service.ResizeImage(Image.FromFile(filePath), 200, 200);
                ptbImage.Image = imgResized;
                _product.Image = imgResized;
                //imgResized.Save(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\" +
                //    txtBarcode.Text + ".jpg", ImageFormat.Jpeg);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var imgRootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\";
            var imgName = txtBarcode.Text + ".jpg";
            var file = new FileInfo(imgRootPath + imgName);
            if (file.Exists)
                file.Delete();
            var data = Mapper.Map<ProductModel, Product>((ProductModel)_source.DataSource);
            if(!string.IsNullOrEmpty(txtPath.Text))
            {
                _product.Image.Save(imgRootPath + imgName, ImageFormat.Jpeg);
                data.Img = txtBarcode.Text + ".jpg";
            }
            
            if (string.IsNullOrEmpty(_barcode))
                _service.Insert(data);
            else
                _service.Update(data);
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(_barcode);
            MessageBox.Show("Xóa thành công!");
        }
        #endregion
    }
}

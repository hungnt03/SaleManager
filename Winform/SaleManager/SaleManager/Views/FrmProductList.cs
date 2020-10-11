using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmProductList : Form
    {
        private ProductService _service;
        public FrmProductList()
        {
            InitializeComponent();
            _service = new ProductService();
            InitView();
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        #region "Event"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitView();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbSuplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var barcode = dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value.ToString();
            var frm = new FrmProduct(barcode);
            frm.Show(this);
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmProduct(string.Empty);
            frm.Show(this);
            this.Hide();
        }
        #endregion

        #region "Init"
        private void InitView()
        {
            var source = new AutoCompleteStringCollection();
            var categoryBinding = new BindingSource();
            var categories = _service.GetCategoryList();
            categories.Insert(0, new KeyValue("-1", string.Empty));
            categoryBinding.DataSource = categories;
            cmbCategory.DataSource = categoryBinding;
            cmbCategory.DisplayMember = "Value";
            cmbCategory.ValueMember = "Key";

            var supplierBinding = new BindingSource();
            var suppliers = _service.GetSupplierList();
            suppliers.Insert(0, new KeyValue("-1", string.Empty));
            supplierBinding.DataSource = suppliers;
            cmbSuplier.DataSource = supplierBinding;
            cmbSuplier.DisplayMember = "Value";
            cmbSuplier.ValueMember = "Key";

            var lstBinding = new BindingSource();
            var producs = _service.GetAll();
            var productsModel = new List<ProductsModel>();
            foreach (var elm in producs)
            {
                productsModel.Add(Mapper.Map<Product, ProductsModel>(elm));
                source.Add(elm.Barcode);
                source.Add(elm.Name);
            }
            lstBinding.DataSource = productsModel;
            dgvData.DataSource = lstBinding;

            //AutoComplete
            txtSearch.AutoCompleteCustomSource = source;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Search();
        }
        #endregion

        private void Search()
        {
            var key = txtSearch.Text;
            var categoryId = (cmbCategory.SelectedIndex <= 0) ? -1 : int.Parse(cmbCategory.SelectedValue.ToString());
            var supplierId = (cmbSuplier.SelectedIndex <= 0) ? -1 : int.Parse(cmbSuplier.SelectedValue.ToString());
            var lstBinding = new BindingSource();
            lstBinding.DataSource = Mapper.Map<IList<Product>, IList<ProductsModel>>(_service.Search(key, categoryId, supplierId));
            dgvData.DataSource = lstBinding;
        }

        
    }
}

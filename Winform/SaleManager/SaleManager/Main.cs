using SaleManager.Controls;
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.Utils;
using SaleManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager
{
    public partial class Main : Form
    {
        private List<BillProductModel> _lst;
        private BindingList<BillProductModel> _bindingLst;
        private BindingSource _src;

        private int _currTabIdx = 0;
        private ProductService _productService;
        public Main()
        {
            InitializeComponent();
            _productService = new ProductService();
            InitView();
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            cardsPanel1.ViewModel = LoadSomeData();
            cardsPanel1.DataBind();
            AddTab();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmProductList();
            frm.Show(this);
            this.Hide();
        }

        private CardsViewModel LoadSomeData()
        {
            var imgRootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources\\Product\\";
            ObservableCollection<CardViewModel> cards = new ObservableCollection<CardViewModel>();
            cards.Add(new CardViewModel()
            {
                Price = 120000,
                Name = "Bánh Sampa Balocco Savoiardi 200g",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg"))
            });

            CardsViewModel VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
        }

        #region "Init"
        private void InitView()
        {
            //var source = new AutoCompleteStringCollection();
            //var producs = _productService.GetAll();
            //foreach (var elm in producs)
            //    source.Add(elm.Barcode);
            //AutoComplete
            //txtSearch.AutoCompleteCustomSource = source;
            //txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void RemoveTab()
        {
            this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
        }

        private void AddTab()
        {
            if (this.tabControl1.TabPages.Count > 5)
                return;
            _currTabIdx += 1;
            var tab = new System.Windows.Forms.TabPage();
            tab.SuspendLayout();
            tab.Name = "tabPage" + _currTabIdx;
            tab.Text = "Hóa đơn " + _currTabIdx;
            tab.UseVisualStyleBackColor = true;
            var grid = CreateDatagridView();
            grid.AutoGenerateColumns = false;
            tab.Controls.Add(grid);
            tab.Size = new System.Drawing.Size(738, 310);
            tab.ResumeLayout(false);
            this.tabControl1.Controls.Add(tab);

            _lst = new List<BillProductModel>() { new BillProductModel("123456", "name", 10, "20000") };
            _bindingLst = new BindingList<BillProductModel>(_lst);
            _src = new BindingSource(_bindingLst, null);
            grid.DataSource = _src;
            _lst.Add(new BillProductModel("321123", "name232", 11, "30000"));
        }

        private DataGridView CreateDatagridView()
        {
            var grid = new System.Windows.Forms.DataGridView();
            grid.Name = "DataGridView" + _currTabIdx;
            var txtBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtBarcode.Name = "barcode";
            txtBarcode.DataPropertyName = "barcode";
            txtBarcode.HeaderText = "";
            txtBarcode.Width = 50;
            var txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtName.Name = "name";
            txtName.DataPropertyName = "name";
            txtName.HeaderText = "Tên sản phẩm";
            txtName.Width = 300;
            var txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtQuantity.Name = "quantity";
            txtQuantity.DataPropertyName = "quantity";
            txtQuantity.HeaderText = "Số lượng";
            txtQuantity.Width = 70;
            var btnUp = new System.Windows.Forms.DataGridViewButtonColumn();
            btnUp.Name = "quantityDown";
            btnUp.DataPropertyName = "quantityDown";
            btnUp.Text = "▼";
            btnUp.HeaderText = "";
            btnUp.Width = 30;
            var btnDown = new System.Windows.Forms.DataGridViewButtonColumn();
            btnDown.Name = "quantityUp";
            btnDown.DataPropertyName = "quantityUp";
            btnDown.HeaderText = "";
            btnDown.Text = "▲";
            btnDown.Width = 30;
            var txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtPrice.Name = "price";
            txtPrice.DataPropertyName = "price";
            txtPrice.HeaderText = "Đơn giá";
            txtPrice.Width = 100;
            var txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtTotal.Name = "total";
            txtTotal.DataPropertyName = "total";
            txtTotal.HeaderText = "Thành tiền";
            txtTotal.Width = 120;
            var btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            btnDel.Name = "del";
            btnDel.DataPropertyName = "del";
            btnDel.HeaderText = "";
            btnDel.Text = "✘";
            btnDel.Width = 30;
            grid.Columns.Add(txtBarcode);
            grid.Columns.Add(txtName);
            grid.Columns.Add(txtQuantity);
            grid.Columns.Add(btnUp);
            grid.Columns.Add(btnDown);
            grid.Columns.Add(txtPrice);
            grid.Columns.Add(txtTotal);
            grid.Columns.Add(btnDel);
            grid.Dock = DockStyle.Fill;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.Columns[0].Visible = false;
            grid.CellClick += grid_CellClick;
            return grid;
        }

        private void AddRow(string barcode)
        {
            var product = _productService.GetById(barcode);
            if (product == null)
                return;
            var grid = (DataGridView)this.tabControl1.SelectedTab.Controls[0];
            grid.Rows.Add(new string[] { product.Barcode, product.Name, "1", "", "", StringUtil.ToCurrentcy(product.Price), StringUtil.ToCurrentcy(product.Price), "" });
        }
        #endregion

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabPages.Count == 1)
                return;
            if (MessageBox.Show("Bạn muốn xóa " + this.tabControl1.SelectedTab.Text + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                RemoveTab();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            //QuantityUp click
            if (e.ColumnIndex == grid.Columns["btnProductQuantityUp"].Index)
            {
                var quantity = int.Parse(grid.Rows[e.RowIndex].Cells[grid.Columns["txtQuantity"].Index].Value.ToString());
                var price = StringUtil.ConvertCurrentcy(grid.Rows[e.RowIndex].Cells[grid.Columns["txtProductPrice"].Index].Value.ToString());
                quantity += 1;
                grid.Rows[e.RowIndex].Cells[grid.Columns["txtQuantity"].Index].Value = quantity.ToString();
                grid.Rows[e.RowIndex].Cells[grid.Columns["txtProductTotal"].Index].Value = StringUtil.ToCurrentcy((quantity * price));
            }
            //QuantityDown click
            if (e.ColumnIndex == grid.Columns["btnProductQuantityDown"].Index)
            {
                var quantity = int.Parse(grid.Rows[e.RowIndex].Cells[grid.Columns["txtQuantity"].Index].Value.ToString());
                var price = StringUtil.ConvertCurrentcy(grid.Rows[e.RowIndex].Cells[grid.Columns["txtProductPrice"].Index].Value.ToString());
                if (quantity == 1)
                    return;
                quantity -= 1;
                grid.Rows[e.RowIndex].Cells[grid.Columns["txtQuantity"].Index].Value = quantity.ToString();
                grid.Rows[e.RowIndex].Cells[grid.Columns["txtProductTotal"].Index].Value = StringUtil.ToCurrentcy((quantity * price));
            }
            //Delete click
            if (e.ColumnIndex == grid.Columns["btnProductDel"].Index)
            {
                grid.Rows.Remove(grid.Rows[e.RowIndex]);
            }
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar.Equals('\b'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var grid = (DataGridView)this.tabControl1.SelectedTab.Controls[0];
            grid.Rows.Add(new string[] { "Ten", "3", "", "", "9000", "27000", "" });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 13)
                AddRow(txtSearch.Text);
        }
    }
}

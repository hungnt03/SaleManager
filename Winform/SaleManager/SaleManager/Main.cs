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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager
{
    public partial class Main : Form
    {
        private Dictionary<int, MainModel> _models;
        private ProductService _productService;
        public Main()
        {
            InitializeComponent();
            _productService = new ProductService();
            _models = new Dictionary<int, MainModel>();
            InitView();
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            cardsPanel1.ViewModel = LoadSomeData();
            cardsPanel1.DataBind();
            for(var idx = 0; idx<5; idx++)
            {
                AddTab(idx);
            }

            foreach (CardControl card in cardsPanel1.Controls)
            {
                foreach (Control child in card.Controls)
                {
                    child.DoubleClick += Card_DoubleClick;
                }
            }
            this.tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            var data = ((CardControl)((Control)sender).Parent)._model;
            var product = _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(data.id)).FirstOrDefault();
            if (product == null)
                _models[tabControl1.SelectedIndex].products.Add(new BillProductModel(_productService.GetById(data.id)));
            else
                _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(data.id)).First().quantity += 1;
            _models[tabControl1.SelectedIndex].Refesh();
            UpdateTotal();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmProductList();
            frm.Show(this);
            this.Hide();
        }
        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmImportProduct();
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
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg")),
                id = "3110354325000"
            });
            cards.Add(new CardViewModel()
            {
                Price = 16000,
                Name = "Sốt ướp thịt nướng",
                Picture = new Bitmap(Image.FromFile(imgRootPath + "8934637514871.jpg")),
                id = "8934637514871"
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

        }

        private void AddTab(int idTab)
        {
            if (this.tabControl1.TabPages.Count > 5)
                return;
            var tab = new System.Windows.Forms.TabPage();
            tab.SuspendLayout();
            tab.Name = "tabPage" + (idTab+1);
            tab.Text = "Hóa đơn " + (idTab+1);
            tab.UseVisualStyleBackColor = true;
            var grid = CreateDatagridView();
            grid.AutoGenerateColumns = false;
            tab.Controls.Add(grid);
            tab.Size = new System.Drawing.Size(738, 310);
            tab.ResumeLayout(false);
            this.tabControl1.Controls.Add(tab);

            var model = new MainModel();
            model.id = idTab;
            _models.Add(model.id, model);
            grid.DataSource = _models[model.id].source;
        }

        private DataGridView CreateDatagridView()
        {
            var grid = new System.Windows.Forms.DataGridView();
            grid.Name = "DataGridView" + tabControl1.SelectedIndex + 1;
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

        private void AddProduct(string barcode)
        {
            var product = _productService.GetById(barcode);

            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm.", "", MessageBoxButtons.OK);
                return;
            }
            if (product.Quantity < 1)
            {
                MessageBox.Show("Sản phẩm này đã hết.", "", MessageBoxButtons.OK);
                return;
            }
            if (_models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(product.Barcode)).Count() > 0)
                _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(product.Barcode)).First().quantity += 1;
            else
                _models[tabControl1.SelectedIndex].products.Add(new BillProductModel(product.Barcode, product.Name, product.Price.ToString()));
            _models[tabControl1.SelectedIndex].Refesh();
        }
        #endregion

        private void UpdateTotal()
        {
            lbTotal.Text = _models[tabControl1.SelectedIndex].GetTotal();
        }


        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var barcode = grid.Rows[e.RowIndex].Cells[grid.Columns["barcode"].Index].Value.ToString();
            //QuantityUp click
            if (e.ColumnIndex == grid.Columns["quantityUp"].Index)
            {
                _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(barcode)).First().quantity += 1;
                _models[tabControl1.SelectedIndex].Refesh();
                UpdateTotal();
            }
            //QuantityDown click
            if (e.ColumnIndex == grid.Columns["quantityDown"].Index)
            {
                var quantity = _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(barcode)).First().quantity;
                if (quantity == 1)
                    return;
                _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(barcode)).First().quantity -= 1;
                _models[tabControl1.SelectedIndex].Refesh();
                UpdateTotal();
            }
            //Delete click
            if (e.ColumnIndex == grid.Columns["del"].Index)
            {
                var product = _models[tabControl1.SelectedIndex].products.Where(x => x.barcode.Equals(barcode)).First();
                _models[tabControl1.SelectedIndex].products.Remove(product);
                _models[tabControl1.SelectedIndex].Refesh();
                UpdateTotal();
            }
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar.Equals('\b'));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 13)
            {
                AddProduct(txtSearch.Text);
                txtSearch.Text = string.Empty;
            }

        }

        #region "event"

        private void btn100_Click(object sender, EventArgs e)
        {
            var money = txtMoneyCustomer.Text;
            txtMoneyCustomer.Text = (money.CurrentcyToNumber() + 100000).ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            var money = txtMoneyCustomer.Text;
            txtMoneyCustomer.Text = (money.CurrentcyToNumber() + 50000).ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            var money = txtMoneyCustomer.Text;
            txtMoneyCustomer.Text = (money.CurrentcyToNumber() + 10000).ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            var money = txtMoneyCustomer.Text;
            txtMoneyCustomer.Text = (money.CurrentcyToNumber() + 5000).ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var money = txtMoneyCustomer.Text;
            txtMoneyCustomer.Text = (money.CurrentcyToNumber() + 1000).ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            var money = txtMoneyCustomer.Text;
            txtMoneyCustomer.Text = (money.CurrentcyToNumber() + 100).ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void btnClearMoney_Click(object sender, EventArgs e)
        {
            txtMoneyCustomer.Text = "0";
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }

        private void txtMoneyCustomer_TextLeave(object sender, EventArgs e)
        {
            if (!txtMoneyCustomer.Text.IsNumberic())
                return;
            txtMoneyCustomer.Text = txtMoneyCustomer.Text.CurrentcyToNumber().ToCurrentcy();
            lblChange.Text = (txtMoneyCustomer.Text.CurrentcyToNumber() - lbTotal.Text.CurrentcyToNumber()).ToCurrentcy();
        }


    }
    #endregion


}

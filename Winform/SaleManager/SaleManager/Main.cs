﻿using SaleManager.Controls;
using SaleManager.Entities;
using SaleManager.Models;
using SaleManager.Utils;
using SaleManager.ViewModels;
using SaleManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SaleManager
{
    public partial class Main : Form
    {
        private MainViewModel _vm = new MainViewModel();
        private DispatcherTimer _searchTimer;
        public Main()
        {
            InitializeComponent();
            _searchTimer = new DispatcherTimer();
            _searchTimer.Interval = new TimeSpan(300);
            this.Load += delegate { _vm.Load(); };
            cardViewModelBindingSource.DataSourceChanged += CardViewModelBindingSource_DataSourceChanged;
            dgvData.CellFormatting += DgvData_CellFormatting;
            dgvData.CellContentClick += DgvData_CellContentClick;
            //Unit
            dgvData.EditingControlShowing += DgvData_EditingControlShowing;
            txtSearchBillProduct.TextChanged += delegate { _vm.SearchBillProduct(txtSearchBillProduct.Text); };            
            txtSearchProduct.TextChanged += TxtSearchProduct_TextChanged;            
            btnClearMoney.Click += delegate { _vm.ClearPayment(); };
            btnPay.Click += delegate { _vm.Pay(); };
            _searchTimer.Tick += OnSearchTimerTick;
            btnExit.Click += BtnExit_Click;
            btnCancel.Click += delegate { _vm.Cancel(); };
            btn01.Click += delegate { _vm.PushPayment(100); };
            btn1.Click += delegate { _vm.PushPayment(1000); };
            btn5.Click += delegate { _vm.PushPayment(5000); };
            btn10.Click += delegate { _vm.PushPayment(10000); };
            btn50.Click += delegate { _vm.PushPayment(50000); };
            btn100.Click += delegate { _vm.PushPayment(100000); };


            _vm._productSource = cardViewModelBindingSource;
            _vm._billSource = billProductModelBindingSource;
            _vm._unitSource = unitBindingSource;
            _vm._mainSource = mainModelBindingSource;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                combo.SelectedIndexChanged -=
                    new EventHandler(ComboBox_SelectedIndexChanged);

                // Add the event handler. 
                combo.SelectedIndexChanged +=
                    new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).SelectedItem is Unit u) _vm.GridUnitChange(u.Id);
        }
        private void OnSearchTimerTick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _vm.SearchProduct(txtSearchProduct.Text);
        }

        private void TxtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _vm.GridButtonClick(sender, e);            
        }
        private void DgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (new List<string>() { "Price", "Total" }.Contains(dgvData.Columns[e.ColumnIndex].DataPropertyName) && e.Value != null)
                e.Value = e.Value.ToString().ToCurrentcy();
        }

        private void CardViewModelBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            cardsPanel1.ViewModel = new CardsViewModel((ObservableCollection<CardViewModel>)cardViewModelBindingSource.DataSource);
            foreach (CardControl card in cardsPanel1.Controls)
            {
                foreach (Control child in card.Controls)
                {
                    child.DoubleClick += Card_DoubleClick;
                }
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            _vm.CardSelected(sender, e);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmProduct();
            frm.Show(this);
            this.Hide();
        }
        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmImportProduct();
            frm.Show(this);
            this.Hide();
        }

        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTransaction();
            frm.Show(this);
            this.Hide();
        }

        private void mãVạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmBarcode();
            frm.Show(this);
            this.Hide();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | Constants.CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void quảnLýChuyểnĐổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmConvertMaster();
            frm.Show(this);
            this.Hide();
        }

        private void chuyểnĐổiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FrmConvert();
            frm.Show(this);
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmSupplier();
            frm.Show(this);
            this.Hide();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmRevenue();
            frm.Show(this);
            this.Hide();
        }
    }
}

using SaleManager.Models;
using SaleManager.Utils;
using SaleManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmTransaction : Form
    {
        private TransitionViewModel _vm = new TransitionViewModel();
        public FrmTransaction()
        {
            InitializeComponent();
            dgvTransition.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransition.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransition.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTransition.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTransition.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Load += delegate { _vm.Load(); };
            dgvTransition.CellFormatting += DgvTransition_CellFormatting;
            dgvTransition.CellDoubleClick += DgvTransition_CellDoubleClick;
            ckbEnableDate.CheckedChanged += CkbEnableDate_CheckedChanged;
            ckbIsPayment.CheckedChanged += CkbIsPayment_CheckedChanged;
            btnSearch.Click += delegate { 
                _vm.Search(ckbIsPayment.Checked, txtKey.Text, ckbType.SelectedItem.ToStringOrEmpty(), 
                    ckbEnableDate.Checked, dtpFrom.Value,dtpTo.Value); };
            btnSave.Click += delegate { _vm.Save(); };
            btnBack.Click += BtnBack_Click;

            _vm._source = transitionModelBindingSource;
            _vm._supplierSource = supplierBindingSource;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CkbIsPayment_CheckedChanged(object sender, EventArgs e)
        {
            ckbIsPayment.Text = ckbIsPayment.Checked ? "Đã thanh toán" : "Nợ";
        }

        private void DgvTransition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTransition.DataSource is List<TransactionModel> trans)
            {
                var detail = new FrmTransactionDetail(trans[e.RowIndex].Id);
                detail.ShowDialog(this);
            }
        }

        private void DgvTransition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (new List<string>() { "Amount", "Payment", "PayBack" }.Contains(dgvTransition.Columns[e.ColumnIndex].DataPropertyName) && e.Value != null)
                e.Value = e.Value.ToString().ToCurrentcy();
            if ("CreateAt".Equals(dgvTransition.Columns[e.ColumnIndex].DataPropertyName) && e.Value != null)
                e.Value = DateTime.Parse(e.Value.ToString()).ToShortDateString();
            if ("IsPayment".Equals(dgvTransition.Columns[e.ColumnIndex].DataPropertyName) && e.Value != null)
                e.Value = e.Value.ToString().Equals("True") ? "〇" : "✘";
            if ("Type".Equals(dgvTransition.Columns[e.ColumnIndex].DataPropertyName) && e.Value != null)
                e.Value = e.Value.ToString().Equals("1") ? "▲" : "▼";
        }

        private void CkbEnableDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEnableDate.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }
        public void Refesh()
        {
            _vm.Search(ckbIsPayment.Checked, txtKey.Text, ckbType.SelectedItem.ToStringOrEmpty(),
                    ckbEnableDate.Checked, dtpFrom.Value, dtpTo.Value);
        }
    }
}

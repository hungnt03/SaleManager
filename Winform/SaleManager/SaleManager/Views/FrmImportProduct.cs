
using SaleManager.Models;
using SaleManager.Services;
using SaleManager.ViewModels;
using SaleManager.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmImportProduct : Form
    {
        private ImportProductService _service;
        private ImportProductViewModel _vm = new ImportProductViewModel();
        public static ImportProductDialogModel _dialogModel;
        public FrmImportProduct()
        {
            InitializeComponent();
            _service = new ImportProductService();
            _dialogModel = new ImportProductDialogModel();
            _vm._source = importProductModelBindingSource;
            _vm._unitSource = unitBindingSource;
            _vm._supplierSource = supplierBindingSource;
            _vm.Initialize();
            btnImport.Click += BtnImport_Click;
            this.Load += delegate { _vm.Load(); };
            btnSave.Click += BtnSave_Click; ;
            DataBindings.Add("Text", _vm, "Title");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(importProductModelBindingSource.DataSource is List<ImportProductModel> datas)
            {
                var dialog = new ImportProductDialog(datas);
                dialog.ShowDialog(this);
                _vm.Save();
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Worksheets|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
                return;
            _vm.Import(filePath);
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _service.CreateTemplate();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("done.");
        }
    }
}

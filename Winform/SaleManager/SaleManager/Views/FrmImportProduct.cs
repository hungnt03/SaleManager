using OfficeOpenXml;
using SaleManager.Models;
using SaleManager.Services;
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
        private List<ImportProductModel> _datas;
        public FrmImportProduct()
        {
            InitializeComponent();
            _service = new ImportProductService();
        }

        private void btnImport_Click(object sender, EventArgs e)
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

            _datas = _service.Read(filePath);
            if (_datas.Count == 0)
                return;
            dgvData.DataSource = new BindingSource(new BindingList<ImportProductModel>(_datas),null);
            unitModelBindingSource.DataSource = _service.GetUnits();
            supplierBindingSource.DataSource = _service.GetSuppliers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

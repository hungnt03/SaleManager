using SaleManager.Models;
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

namespace SaleManager.Views.Dialogs
{
    public partial class ImportProductDialog : Form
    {
        public ImportProductDialog(List<ImportProductModel> datas)
        {
            InitializeComponent();
            importProductDialogModelBindingSource.DataSource = 
                new ImportProductDialogModel() { Total = datas.Sum(x => x.Total).ToString().ToInt() };
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.Owner is FrmImportProduct) FrmImportProduct._dialogModel = (ImportProductDialogModel)importProductDialogModelBindingSource.Current;
            this.Close();
        }

        private void DebtcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DebtcheckBox.Checked)
            {
                paybackTextBox.ReadOnly = true;
                paymentTextBox.ReadOnly = true;
            }
            else
            {
                paybackTextBox.ReadOnly = false;
                paymentTextBox.ReadOnly = false;
            }
        }
    }
}

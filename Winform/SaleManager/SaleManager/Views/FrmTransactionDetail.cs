using SaleManager.ViewModels;
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
    public partial class FrmTransactionDetail : Form
    {
        private int Id { set; get; }
        private TransactionDetailViewModel _vm = new TransactionDetailViewModel();
        public FrmTransactionDetail(int id)
        {
            InitializeComponent();
            this.Load += delegate { _vm.Load(id); };
            btnBack.Click += BtnBack_Click;
            btnDelete.Click += delegate { _vm.Delete(); };

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

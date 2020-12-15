using SaleManager.Utils;
using SaleManager.ViewModels;
using System;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmSupplier : Form
    {
        private SupplierViewModel _vm = new SupplierViewModel();
        public FrmSupplier()
        {
            InitializeComponent();
            this.Load += delegate { _vm.Load(); };
            btnSave.Click += delegate { _vm.Save(); };
            btnDelete.Click += delegate { _vm.Delete(); };
            btnBack.Click += BtnBack_Click;

            _vm._source = supplierModelBindingSource;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
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
    }
}

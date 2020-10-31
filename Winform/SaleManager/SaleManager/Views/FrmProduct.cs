using SaleManager.ViewModels;
using System;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmProduct : Form
    {
        private ProductViewModel _vm = new ProductViewModel();
        public FrmProduct()
        {
            InitializeComponent();
            this.Load += delegate { _vm.Load(); };
            btnSearch.Click += delegate { _vm.Search(txtSearch.Text); };
            btnAddImage.Click += delegate { _vm.AddImage(); };
            btnAdd.Click += BtnAdd_Click;
            btnSave.Click += delegate { _vm.Save(); };

            _vm._source = productModelBindingSource;
            _vm._unitSource = unitBindingSource;
            _vm._supplierSource = supplierBindingSource;
            _vm._categorySource = categoryBindingSource;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _vm.Add();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}

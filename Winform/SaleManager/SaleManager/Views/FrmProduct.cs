using SaleManager.Utils;
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
            btnAdd.Click += delegate { _vm.AddRow(); };
            btnSave.Click += delegate { _vm.Save(); };
            
            _vm._source = productModelBindingSource;
            _vm._unitSource = unitBindingSource;
            _vm._supplierSource = supplierBindingSource;
            _vm._categorySource = categoryBindingSource;
            _vm.Initialize();

            btnRecycling.Click += delegate { _vm.RecyclingCommand.Execute(); };
            btnRecycling.DataBindings.Add(_vm.RecyclingCommand.EnabledBinding);
            barcodeTextBox.TextChanged += delegate { _vm.BarcodeCommand.Execute(); };
            barcodeTextBox.DataBindings.Add(_vm.BarcodeCommand.EnabledBinding);
        }
        private void btnBack_Click(object sender, EventArgs e)
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

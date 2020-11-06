using SaleManager.ViewModels;
using System;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmConvert : Form
    {
        private ConvertProductViewModel _vm = new ConvertProductViewModel();
        public FrmConvert()
        {
            InitializeComponent();
            this.Load += delegate { _vm.Load(); };
            btnAddRow.Click += delegate { _vm.AddRow(); };
            btnSave.Click += delegate { _vm.Save(); };
            btnExit.Click += BtnExit_Click;

            _vm._convertSource = convertModelBindingSource;
            _vm._unitSource = unitBindingSource;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}

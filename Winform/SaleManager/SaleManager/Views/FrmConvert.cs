using SaleManager.ViewModels;
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
            btnConvert.Click += delegate { _vm.Convert(); };
            btnBack.Click += BtnBack_Click;
            _vm._source = convertProductModelBindingSource;
            _vm._productSource1 = productModelBindingSource;
            _vm._productSource2 = productModelBindingSource1;
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}

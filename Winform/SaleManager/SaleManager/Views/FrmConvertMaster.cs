using SaleManager.ViewModels;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmConvertMaster : Form
    {
        private ConvertMasterViewModel _vm = new ConvertMasterViewModel();
        public FrmConvertMaster()
        {
            InitializeComponent();
            this.Load += delegate { _vm.Load(); };
            btnSave.Click += delegate { _vm.Save(); };
            btnAdd.Click += delegate { _vm.AddRow(); };
            btnBack.Click += BtnBack_Click;
            _vm._convertSource = convertMasterModelBindingSource;
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}

using SaleManager.Utils;
using SaleManager.ViewModels;
using System.Windows.Forms;

namespace SaleManager.Views
{
    public partial class FrmBarcode : Form
    {
        private BarcodeViewModel _vm = new BarcodeViewModel();
        public FrmBarcode()
        {
            InitializeComponent();
            this.Load += delegate { _vm.Load(); };
            btnExport.Click += delegate { _vm.Export(); };
            _vm._source = barcodeModelBindingSource;
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

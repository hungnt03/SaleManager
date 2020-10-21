using SaleManager.Services;
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
    public partial class FrmConvert : Form
    {
        private ConvertService _convertService;
        private UnitService _unitSrvice;
        public FrmConvert()
        {
            InitializeComponent();
            _convertService = new ConvertService();
            _unitSrvice = new UnitService();
            dgvData.AutoGenerateColumns = false;
        }

        private void FrmConvert_Load(object sender, EventArgs e)
        {
            unit1ModelBindingSource.DataSource = _convertService.GetUnits1();
            unit2ModelBindingSource.DataSource = _convertService.GetUnits2();
            dgvData.DataSource = _convertService.GetAll();
        }
    }
}

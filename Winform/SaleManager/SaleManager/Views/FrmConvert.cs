using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
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
        private BindingList<ConvertModel> _binding;
        private List<ConvertModel> _converts;
        public BindingSource _source { get; }
        public FrmConvert()
        {
            InitializeComponent();
            _convertService = new ConvertService();
            _unitSrvice = new UnitService();
            dgvData.AutoGenerateColumns = false;
        }

        private void FrmConvert_Load(object sender, EventArgs e)
        {
            var converts = _convertService.GetAll();
            converts.Add(new ConvertModel());
            dgvData.DataSource = converts;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var data = (List<ConvertModel>)dgvData.DataSource;
            var convertProducts = Mapper.Map<IEnumerable<ConvertModel>, List<ConvertProduct>>(data);
            var a = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

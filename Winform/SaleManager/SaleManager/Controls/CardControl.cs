using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SaleManager.Controls
{
    public partial class CardControl : UserControl
    {
        public CardViewModel _model { get; set; }

        public CardControl()
        {
            InitializeComponent();            
        }

        public CardControl(CardViewModel viewModel)
        {
            _model = viewModel;
            InitializeComponent();
        }

        public void DataBind()
        {
            SuspendLayout();

            lblName.Text = _model.Name.ToString();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lblPrice.Text = _model.Price.ToString("#,###", cul.NumberFormat);
            pictureBox.Image = _model.Picture;

            ResumeLayout();
        }
    }
}

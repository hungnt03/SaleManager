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
using SaleManager.Utils;

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

            lblPrice.Text = StringUtil.ToCurrentcy(_model.Price);
            pictureBox.Image = _model.Picture;

            ResumeLayout();
        }
    }
}

﻿using System;
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
    public partial class FrmTransactionDetail : Form
    {
        private int Id { set; get; }
        public FrmTransactionDetail(int Id)
        {
            InitializeComponent();
        }
    }
}

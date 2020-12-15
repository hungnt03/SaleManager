namespace SaleManager.Views
{
    partial class FrmConvert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label barcode1Label;
            System.Windows.Forms.Label barcode2Label;
            System.Windows.Forms.Label quantity1Label;
            System.Windows.Forms.Label quantity2Label;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barcode1ComboBox = new System.Windows.Forms.ComboBox();
            this.convertProductModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcode2ComboBox = new System.Windows.Forms.ComboBox();
            this.productModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quantity1ComboBox = new System.Windows.Forms.ComboBox();
            this.quantity2TextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            barcode1Label = new System.Windows.Forms.Label();
            barcode2Label = new System.Windows.Forms.Label();
            quantity1Label = new System.Windows.Forms.Label();
            quantity2Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convertProductModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barcode1Label
            // 
            barcode1Label.AutoSize = true;
            barcode1Label.Location = new System.Drawing.Point(22, 36);
            barcode1Label.Name = "barcode1Label";
            barcode1Label.Size = new System.Drawing.Size(70, 14);
            barcode1Label.TabIndex = 0;
            barcode1Label.Text = "Chuyển SP";
            // 
            // barcode2Label
            // 
            barcode2Label.AutoSize = true;
            barcode2Label.Location = new System.Drawing.Point(22, 78);
            barcode2Label.Name = "barcode2Label";
            barcode2Label.Size = new System.Drawing.Size(56, 14);
            barcode2Label.TabIndex = 2;
            barcode2Label.Text = "Sang SP";
            // 
            // quantity1Label
            // 
            quantity1Label.AutoSize = true;
            quantity1Label.Location = new System.Drawing.Point(328, 39);
            quantity1Label.Name = "quantity1Label";
            quantity1Label.Size = new System.Drawing.Size(63, 14);
            quantity1Label.TabIndex = 8;
            quantity1Label.Text = "Số luợng";
            // 
            // quantity2Label
            // 
            quantity2Label.AutoSize = true;
            quantity2Label.Location = new System.Drawing.Point(328, 81);
            quantity2Label.Name = "quantity2Label";
            quantity2Label.Size = new System.Drawing.Size(63, 14);
            quantity2Label.TabIndex = 10;
            quantity2Label.Text = "Số lượng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 219);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(barcode1Label);
            this.panel1.Controls.Add(this.barcode1ComboBox);
            this.panel1.Controls.Add(barcode2Label);
            this.panel1.Controls.Add(this.barcode2ComboBox);
            this.panel1.Controls.Add(quantity1Label);
            this.panel1.Controls.Add(this.quantity1ComboBox);
            this.panel1.Controls.Add(quantity2Label);
            this.panel1.Controls.Add(this.quantity2TextBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 222);
            this.panel1.TabIndex = 1;
            // 
            // barcode1ComboBox
            // 
            this.barcode1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.convertProductModelBindingSource, "Barcode1", true));
            this.barcode1ComboBox.DataSource = this.productModelBindingSource;
            this.barcode1ComboBox.DisplayMember = "Name";
            this.barcode1ComboBox.FormattingEnabled = true;
            this.barcode1ComboBox.Location = new System.Drawing.Point(100, 33);
            this.barcode1ComboBox.Name = "barcode1ComboBox";
            this.barcode1ComboBox.Size = new System.Drawing.Size(215, 22);
            this.barcode1ComboBox.TabIndex = 1;
            this.barcode1ComboBox.ValueMember = "Barcode";
            // 
            // convertProductModelBindingSource
            // 
            this.convertProductModelBindingSource.DataSource = typeof(SaleManager.Models.ConvertProductModel);
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(SaleManager.Models.ProductModel);
            // 
            // barcode2ComboBox
            // 
            this.barcode2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.convertProductModelBindingSource, "Barcode2", true));
            this.barcode2ComboBox.DataSource = this.productModelBindingSource1;
            this.barcode2ComboBox.DisplayMember = "Name";
            this.barcode2ComboBox.FormattingEnabled = true;
            this.barcode2ComboBox.Location = new System.Drawing.Point(100, 75);
            this.barcode2ComboBox.Name = "barcode2ComboBox";
            this.barcode2ComboBox.Size = new System.Drawing.Size(215, 22);
            this.barcode2ComboBox.TabIndex = 3;
            this.barcode2ComboBox.ValueMember = "Barcode";
            // 
            // productModelBindingSource1
            // 
            this.productModelBindingSource1.DataSource = typeof(SaleManager.Models.ProductModel);
            // 
            // quantity1ComboBox
            // 
            this.quantity1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.convertProductModelBindingSource, "Quantity1", true));
            this.quantity1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.convertProductModelBindingSource, "Quantity1", true));
            this.quantity1ComboBox.FormattingEnabled = true;
            this.quantity1ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.quantity1ComboBox.Location = new System.Drawing.Point(411, 36);
            this.quantity1ComboBox.Name = "quantity1ComboBox";
            this.quantity1ComboBox.Size = new System.Drawing.Size(69, 22);
            this.quantity1ComboBox.TabIndex = 9;
            // 
            // quantity2TextBox
            // 
            this.quantity2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.convertProductModelBindingSource, "Quantity2", true));
            this.quantity2TextBox.Location = new System.Drawing.Point(411, 78);
            this.quantity2TextBox.Name = "quantity2TextBox";
            this.quantity2TextBox.ReadOnly = true;
            this.quantity2TextBox.Size = new System.Drawing.Size(69, 22);
            this.quantity2TextBox.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnBack);
            this.flowLayoutPanel2.Controls.Add(this.btnConvert);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 168);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(504, 51);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(414, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 44);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(321, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 44);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 219);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmConvert";
            this.Text = "FrmConvert";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convertProductModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox barcode1ComboBox;
        private System.Windows.Forms.BindingSource convertProductModelBindingSource;
        private System.Windows.Forms.ComboBox barcode2ComboBox;
        private System.Windows.Forms.ComboBox quantity1ComboBox;
        private System.Windows.Forms.TextBox quantity2TextBox;
        private System.Windows.Forms.BindingSource productModelBindingSource;
        private System.Windows.Forms.BindingSource productModelBindingSource1;
    }
}
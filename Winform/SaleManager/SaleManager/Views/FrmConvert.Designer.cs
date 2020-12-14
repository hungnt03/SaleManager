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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbProduct1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbQuantity1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProduct2 = new System.Windows.Forms.ComboBox();
            this.tbQuantity2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 231);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnBack);
            this.flowLayoutPanel2.Controls.Add(this.btnConvert);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 180);
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
            // cbProduct1
            // 
            this.cbProduct1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct1.FormattingEnabled = true;
            this.cbProduct1.Location = new System.Drawing.Point(126, 33);
            this.cbProduct1.Name = "cbProduct1";
            this.cbProduct1.Size = new System.Drawing.Size(140, 22);
            this.cbProduct1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbQuantity2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbProduct2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbQuantity1);
            this.panel1.Controls.Add(this.cbProduct1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 169);
            this.panel1.TabIndex = 1;
            // 
            // cbQuantity1
            // 
            this.cbQuantity1.FormattingEnabled = true;
            this.cbQuantity1.Location = new System.Drawing.Point(344, 33);
            this.cbQuantity1.Name = "cbQuantity1";
            this.cbQuantity1.Size = new System.Drawing.Size(86, 22);
            this.cbQuantity1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chuyển sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sang sản phẩm";
            // 
            // cbProduct2
            // 
            this.cbProduct2.FormattingEnabled = true;
            this.cbProduct2.Location = new System.Drawing.Point(126, 83);
            this.cbProduct2.Name = "cbProduct2";
            this.cbProduct2.Size = new System.Drawing.Size(140, 22);
            this.cbProduct2.TabIndex = 4;
            // 
            // tbQuantity2
            // 
            this.tbQuantity2.Location = new System.Drawing.Point(344, 84);
            this.tbQuantity2.Name = "tbQuantity2";
            this.tbQuantity2.ReadOnly = true;
            this.tbQuantity2.Size = new System.Drawing.Size(86, 22);
            this.tbQuantity2.TabIndex = 8;
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 231);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmConvert";
            this.Text = "FrmConvert";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQuantity2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProduct2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuantity1;
        private System.Windows.Forms.ComboBox cbProduct1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConvert;
    }
}
namespace SaleManager.Views.Dialogs
{
    partial class ImportProductDialog
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
            System.Windows.Forms.Label paybackLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label totalLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.DebtcheckBox = new System.Windows.Forms.CheckBox();
            this.importProductDialogModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paybackTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSet = new System.Windows.Forms.Button();
            paybackLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importProductDialogModelBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paybackLabel
            // 
            paybackLabel.AutoSize = true;
            paybackLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paybackLabel.Location = new System.Drawing.Point(12, 166);
            paybackLabel.Name = "paybackLabel";
            paybackLabel.Size = new System.Drawing.Size(64, 18);
            paybackLabel.TabIndex = 0;
            paybackLabel.Text = "Trả lại";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paymentLabel.Location = new System.Drawing.Point(12, 114);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(72, 18);
            paymentLabel.TabIndex = 2;
            paymentLabel.Text = "Tiền trả";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(12, 63);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(120, 18);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Tổng tiền hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DebtcheckBox);
            this.panel1.Controls.Add(paybackLabel);
            this.panel1.Controls.Add(this.paybackTextBox);
            this.panel1.Controls.Add(paymentLabel);
            this.panel1.Controls.Add(this.paymentTextBox);
            this.panel1.Controls.Add(totalLabel);
            this.panel1.Controls.Add(this.totalTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 250);
            this.panel1.TabIndex = 0;
            // 
            // DebtcheckBox
            // 
            this.DebtcheckBox.AutoSize = true;
            this.DebtcheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.importProductDialogModelBindingSource, "IsDebt", true));
            this.DebtcheckBox.Location = new System.Drawing.Point(160, 17);
            this.DebtcheckBox.Name = "DebtcheckBox";
            this.DebtcheckBox.Size = new System.Drawing.Size(37, 16);
            this.DebtcheckBox.TabIndex = 7;
            this.DebtcheckBox.Text = "Nợ";
            this.DebtcheckBox.UseVisualStyleBackColor = true;
            this.DebtcheckBox.CheckedChanged += new System.EventHandler(this.DebtcheckBox_CheckedChanged);
            // 
            // importProductDialogModelBindingSource
            // 
            this.importProductDialogModelBindingSource.DataSource = typeof(SaleManager.Models.ImportProductDialogModel);
            // 
            // paybackTextBox
            // 
            this.paybackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductDialogModelBindingSource, "Payback", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.paybackTextBox.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.paybackTextBox.Location = new System.Drawing.Point(160, 155);
            this.paybackTextBox.Multiline = true;
            this.paybackTextBox.Name = "paybackTextBox";
            this.paybackTextBox.Size = new System.Drawing.Size(196, 29);
            this.paybackTextBox.TabIndex = 1;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductDialogModelBindingSource, "Payment", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.paymentTextBox.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.paymentTextBox.Location = new System.Drawing.Point(160, 103);
            this.paymentTextBox.Multiline = true;
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(196, 29);
            this.paymentTextBox.TabIndex = 3;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductDialogModelBindingSource, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.totalTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(160, 52);
            this.totalTextBox.Multiline = true;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(196, 29);
            this.totalTextBox.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSet);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 212);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(343, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 32);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Ok";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // ImportProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 250);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ImportProductDialog";
            this.Text = "ImportProductDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importProductDialogModelBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox paybackTextBox;
        private System.Windows.Forms.BindingSource importProductDialogModelBindingSource;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.CheckBox DebtcheckBox;
    }
}
namespace SaleManager.Views
{
    partial class FrmTransactionDetail
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
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label priceLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transactionDetailModelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            amountLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailModelBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(3, 16);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(77, 14);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Thành tiền";
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Location = new System.Drawing.Point(3, 21);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(63, 14);
            barcodeLabel.TabIndex = 2;
            barcodeLabel.Text = "Barcode:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(3, 7);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(63, 14);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Số lượng";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(3, 10);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(49, 14);
            unitLabel.TabIndex = 12;
            unitLabel.Text = "Đơn vị";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(3, 15);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(56, 14);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "Giá bán";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 519);
            this.splitContainer1.SplitterDistance = 788;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.transactionDetailModelDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 519);
            this.panel2.TabIndex = 1;
            // 
            // transactionDetailModelDataGridView
            // 
            this.transactionDetailModelDataGridView.AllowUserToAddRows = false;
            this.transactionDetailModelDataGridView.AllowUserToDeleteRows = false;
            this.transactionDetailModelDataGridView.AutoGenerateColumns = false;
            this.transactionDetailModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDetailModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.transactionDetailModelDataGridView.DataSource = this.transactionDetailModelBindingSource;
            this.transactionDetailModelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionDetailModelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.transactionDetailModelDataGridView.Name = "transactionDetailModelDataGridView";
            this.transactionDetailModelDataGridView.ReadOnly = true;
            this.transactionDetailModelDataGridView.RowTemplate.Height = 21;
            this.transactionDetailModelDataGridView.Size = new System.Drawing.Size(788, 519);
            this.transactionDetailModelDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Đơn vị";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // transactionDetailModelBindingSource
            // 
            this.transactionDetailModelBindingSource.DataSource = typeof(SaleManager.Models.TransactionDetailModel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnBack);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 471);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(302, 48);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(212, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 41);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 519);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(barcodeLabel);
            this.panel3.Controls.Add(this.barcodeTextBox);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 35);
            this.panel3.TabIndex = 14;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionDetailModelBindingSource, "Barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(82, 13);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.ReadOnly = true;
            this.barcodeTextBox.Size = new System.Drawing.Size(198, 22);
            this.barcodeTextBox.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(priceLabel);
            this.panel4.Controls.Add(this.priceTextBox);
            this.panel4.Location = new System.Drawing.Point(3, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 35);
            this.panel4.TabIndex = 15;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionDetailModelBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.priceTextBox.Location = new System.Drawing.Point(82, 12);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(198, 22);
            this.priceTextBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(quantityLabel);
            this.panel5.Controls.Add(this.quantityTextBox);
            this.panel5.Location = new System.Drawing.Point(3, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 35);
            this.panel5.TabIndex = 16;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionDetailModelBindingSource, "Quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.quantityTextBox.Location = new System.Drawing.Point(82, 3);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(198, 22);
            this.quantityTextBox.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(unitLabel);
            this.panel6.Controls.Add(this.unitComboBox);
            this.panel6.Location = new System.Drawing.Point(3, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 35);
            this.panel6.TabIndex = 17;
            // 
            // unitComboBox
            // 
            this.unitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionDetailModelBindingSource, "Unit", true));
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(82, 1);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(198, 22);
            this.unitComboBox.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.amountTextBox);
            this.panel7.Controls.Add(amountLabel);
            this.panel7.Location = new System.Drawing.Point(3, 167);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 35);
            this.panel7.TabIndex = 18;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionDetailModelBindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.amountTextBox.Location = new System.Drawing.Point(82, 8);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(198, 22);
            this.amountTextBox.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 208);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(283, 35);
            this.panel8.TabIndex = 19;
            // 
            // FrmTransactionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 525);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTransactionDetail";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "FrmTransactionDetail";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailModelBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView transactionDetailModelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource transactionDetailModelBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}
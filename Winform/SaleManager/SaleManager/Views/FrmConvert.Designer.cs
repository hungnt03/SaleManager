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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantity2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.convertModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.btnAddRow);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(680, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.Location = new System.Drawing.Point(546, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantity1DataGridViewTextBoxColumn,
            this.unit1DataGridViewTextBoxColumn,
            this.quantity2DataGridViewTextBoxColumn,
            this.unit2DataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.convertModelBindingSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 21;
            this.dgvData.Size = new System.Drawing.Size(744, 411);
            this.dgvData.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 411);
            this.panel1.TabIndex = 3;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(613, 3);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(61, 31);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "Thêm";
            this.btnAddRow.UseVisualStyleBackColor = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantity1DataGridViewTextBoxColumn
            // 
            this.quantity1DataGridViewTextBoxColumn.DataPropertyName = "Quantity1";
            this.quantity1DataGridViewTextBoxColumn.HeaderText = "Số lượng 1";
            this.quantity1DataGridViewTextBoxColumn.Name = "quantity1DataGridViewTextBoxColumn";
            // 
            // unit1DataGridViewTextBoxColumn
            // 
            this.unit1DataGridViewTextBoxColumn.DataPropertyName = "Unit1";
            this.unit1DataGridViewTextBoxColumn.DataSource = this.unitBindingSource;
            this.unit1DataGridViewTextBoxColumn.DisplayMember = "Name";
            this.unit1DataGridViewTextBoxColumn.HeaderText = "Đơn vị 1";
            this.unit1DataGridViewTextBoxColumn.Name = "unit1DataGridViewTextBoxColumn";
            this.unit1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unit1DataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(SaleManager.Entities.Unit);
            // 
            // quantity2DataGridViewTextBoxColumn
            // 
            this.quantity2DataGridViewTextBoxColumn.DataPropertyName = "Quantity2";
            this.quantity2DataGridViewTextBoxColumn.HeaderText = "Số lượng 2";
            this.quantity2DataGridViewTextBoxColumn.Name = "quantity2DataGridViewTextBoxColumn";
            // 
            // unit2DataGridViewTextBoxColumn
            // 
            this.unit2DataGridViewTextBoxColumn.DataPropertyName = "Unit2";
            this.unit2DataGridViewTextBoxColumn.DataSource = this.unitBindingSource;
            this.unit2DataGridViewTextBoxColumn.DisplayMember = "Name";
            this.unit2DataGridViewTextBoxColumn.HeaderText = "Đơn vị 2";
            this.unit2DataGridViewTextBoxColumn.Name = "unit2DataGridViewTextBoxColumn";
            this.unit2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unit2DataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // convertModelBindingSource
            // 
            this.convertModelBindingSource.DataSource = typeof(SaleManager.Models.ConvertModel);
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmConvert";
            this.Text = "FrmConvert";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.BindingSource convertModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddRow;
    }
}
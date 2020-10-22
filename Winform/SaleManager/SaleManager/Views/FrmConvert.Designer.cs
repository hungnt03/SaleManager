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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unit1ModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unit2ModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit1ModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit2ModelBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.Name,
            this.Quantity1,
            this.Unit1,
            this.Quantity2,
            this.Unit2});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 21;
            this.dgvData.Size = new System.Drawing.Size(843, 450);
            this.dgvData.TabIndex = 0;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "Barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.Width = 150;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Ten san pham";
            this.Name.Name = "Name";
            this.Name.Width = 250;
            // 
            // Quantity1
            // 
            this.Quantity1.DataPropertyName = "Quantity1";
            this.Quantity1.HeaderText = "Số lượng1";
            this.Quantity1.Name = "Quantity1";
            // 
            // Unit1
            // 
            this.Unit1.DataPropertyName = "Unit1";
            this.Unit1.DataSource = this.unit1ModelBindingSource;
            this.Unit1.DisplayMember = "Name";
            this.Unit1.HeaderText = "Đơn vị1";
            this.Unit1.Name = "Unit1";
            this.Unit1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unit1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unit1.ValueMember = "Unit1";
            // 
            // unit1ModelBindingSource
            // 
            this.unit1ModelBindingSource.DataSource = typeof(SaleManager.Models.Unit1Model);
            // 
            // Quantity2
            // 
            this.Quantity2.DataPropertyName = "Quantity2";
            this.Quantity2.HeaderText = "Số lượng2";
            this.Quantity2.Name = "Quantity2";
            // 
            // Unit2
            // 
            this.Unit2.DataPropertyName = "Unit2";
            this.Unit2.DataSource = this.unit2ModelBindingSource;
            this.Unit2.DisplayMember = "Name";
            this.Unit2.HeaderText = "Đơn vị2";
            this.Unit2.Name = "Unit2";
            this.Unit2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unit2.ValueMember = "Unit2";
            // 
            // unit2ModelBindingSource
            // 
            this.unit2ModelBindingSource.DataSource = typeof(SaleManager.Models.Unit2Model);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(843, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(779, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(712, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(645, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvData);
            this.Name = "FrmConvert";
            this.Text = "FrmConvert";
            this.Load += new System.EventHandler(this.FrmConvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit1ModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit2ModelBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit1;
        private System.Windows.Forms.BindingSource unit1ModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit2;
        private System.Windows.Forms.BindingSource unit2ModelBindingSource;
        private System.Windows.Forms.Button btnAdd;
    }
}
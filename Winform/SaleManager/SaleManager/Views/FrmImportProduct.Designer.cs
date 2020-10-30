namespace SaleManager.Views
{
    partial class FrmImportProduct
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
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label exLabel;
            System.Windows.Forms.Label interestLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label priceBuyLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.ComboBox unitCombobox;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridView dgvData;
            this.importProductModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.priceBuyTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.supplierCombobox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.exDateTimePicker = new System.Windows.Forms.DateTimePicker();
            barcodeLabel = new System.Windows.Forms.Label();
            exLabel = new System.Windows.Forms.Label();
            interestLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            priceBuyLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            unitCombobox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.importProductModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dgvData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barcodeLabel.Location = new System.Drawing.Point(3, 8);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(56, 15);
            barcodeLabel.TabIndex = 0;
            barcodeLabel.Text = "Barcode";
            // 
            // exLabel
            // 
            exLabel.AutoSize = true;
            exLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exLabel.Location = new System.Drawing.Point(2, 12);
            exLabel.Name = "exLabel";
            exLabel.Size = new System.Drawing.Size(84, 15);
            exLabel.TabIndex = 2;
            exLabel.Text = "Hạn sử dụng";
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            interestLabel.Location = new System.Drawing.Point(2, 9);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(28, 15);
            interestLabel.TabIndex = 4;
            interestLabel.Text = "Lãi";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(3, 10);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(56, 15);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Giá bán";
            // 
            // priceBuyLabel
            // 
            priceBuyLabel.AutoSize = true;
            priceBuyLabel.Location = new System.Drawing.Point(7, 10);
            priceBuyLabel.Name = "priceBuyLabel";
            priceBuyLabel.Size = new System.Drawing.Size(57, 12);
            priceBuyLabel.TabIndex = 8;
            priceBuyLabel.Text = "Price Buy:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productNameLabel.Location = new System.Drawing.Point(3, 10);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(91, 15);
            productNameLabel.TabIndex = 10;
            productNameLabel.Text = "Tên sản phẩm";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(3, 9);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(63, 15);
            quantityLabel.TabIndex = 12;
            quantityLabel.Text = "Số lượng";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierLabel.Location = new System.Drawing.Point(3, 10);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(28, 15);
            supplierLabel.TabIndex = 14;
            supplierLabel.Text = "NPP";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(2, 6);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(77, 15);
            totalLabel.TabIndex = 16;
            totalLabel.Text = "Thành tiền";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitLabel.Location = new System.Drawing.Point(3, 9);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(49, 15);
            unitLabel.TabIndex = 18;
            unitLabel.Text = "Đơn vị";
            // 
            // unitCombobox
            // 
            unitCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.importProductModelBindingSource, "Unit", true));
            unitCombobox.DataSource = this.unitBindingSource;
            unitCombobox.DisplayMember = "Name";
            unitCombobox.FormattingEnabled = true;
            unitCombobox.Location = new System.Drawing.Point(92, 6);
            unitCombobox.Name = "unitCombobox";
            unitCombobox.Size = new System.Drawing.Size(199, 20);
            unitCombobox.TabIndex = 26;
            unitCombobox.ValueMember = "Id";
            // 
            // importProductModelBindingSource
            // 
            this.importProductModelBindingSource.DataSource = typeof(SaleManager.Models.ImportProductModel);
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(SaleManager.Entities.Unit);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 12);
            label1.TabIndex = 8;
            label1.Text = "Price Buy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Giá mua";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.ProductName,
            this.Total,
            this.Quantity,
            this.PriceBuy,
            this.Price,
            this.Interest,
            this.Ex,
            this.barcodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.priceBuyDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.exDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn});
            dgvData.DataSource = this.importProductModelBindingSource;
            dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvData.Location = new System.Drawing.Point(0, 0);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 21;
            dgvData.Size = new System.Drawing.Size(700, 403);
            dgvData.TabIndex = 0;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // PriceBuy
            // 
            this.PriceBuy.DataPropertyName = "PriceBuy";
            this.PriceBuy.HeaderText = "Giá mua";
            this.PriceBuy.Name = "PriceBuy";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá bán";
            this.Price.Name = "Price";
            // 
            // Interest
            // 
            this.Interest.DataPropertyName = "Interest";
            this.Interest.HeaderText = "Tiền lãi";
            this.Interest.Name = "Interest";
            // 
            // Ex
            // 
            this.Ex.DataPropertyName = "Ex";
            this.Ex.HeaderText = "Hsd";
            this.Ex.Name = "Ex";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // priceBuyDataGridViewTextBoxColumn
            // 
            this.priceBuyDataGridViewTextBoxColumn.DataPropertyName = "PriceBuy";
            this.priceBuyDataGridViewTextBoxColumn.HeaderText = "PriceBuy";
            this.priceBuyDataGridViewTextBoxColumn.Name = "priceBuyDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // exDataGridViewTextBoxColumn
            // 
            this.exDataGridViewTextBoxColumn.DataPropertyName = "Ex";
            this.exDataGridViewTextBoxColumn.HeaderText = "Ex";
            this.exDataGridViewTextBoxColumn.Name = "exDataGridViewTextBoxColumn";
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnImport);
            this.flowLayoutPanel1.Controls.Add(this.btnTemplate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 403);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1027, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(955, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(882, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(809, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(67, 33);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Nhập";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(736, 3);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(67, 33);
            this.btnTemplate.TabIndex = 3;
            this.btnTemplate.Text = "Lấy mẫu";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(dgvData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 403);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel9);
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Controls.Add(this.panel11);
            this.flowLayoutPanel2.Controls.Add(this.panel8);
            this.flowLayoutPanel2.Controls.Add(this.panel10);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(323, 403);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.barcodeTextBox);
            this.panel1.Controls.Add(barcodeLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 29);
            this.panel1.TabIndex = 21;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "Barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(92, 8);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.ReadOnly = true;
            this.barcodeTextBox.Size = new System.Drawing.Size(200, 19);
            this.barcodeTextBox.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.productNameTextBox);
            this.panel9.Controls.Add(productNameLabel);
            this.panel9.Location = new System.Drawing.Point(3, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(295, 29);
            this.panel9.TabIndex = 25;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(92, 6);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.productNameTextBox.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.totalTextBox);
            this.panel7.Controls.Add(totalLabel);
            this.panel7.Location = new System.Drawing.Point(3, 73);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 29);
            this.panel7.TabIndex = 23;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.totalTextBox.Location = new System.Drawing.Point(92, 6);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 19);
            this.totalTextBox.TabIndex = 17;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.priceBuyTextBox);
            this.panel11.Controls.Add(label2);
            this.panel11.Location = new System.Drawing.Point(3, 108);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(295, 29);
            this.panel11.TabIndex = 26;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.textBox1);
            this.panel12.Controls.Add(label1);
            this.panel12.Location = new System.Drawing.Point(4, 28);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(295, 29);
            this.panel12.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "PriceBuy", true));
            this.textBox1.Location = new System.Drawing.Point(92, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 9;
            // 
            // priceBuyTextBox
            // 
            this.priceBuyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "PriceBuy", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.priceBuyTextBox.Location = new System.Drawing.Point(92, 9);
            this.priceBuyTextBox.Name = "priceBuyTextBox";
            this.priceBuyTextBox.Size = new System.Drawing.Size(200, 19);
            this.priceBuyTextBox.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.quantityTextBox);
            this.panel8.Controls.Add(quantityLabel);
            this.panel8.Location = new System.Drawing.Point(3, 143);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(295, 29);
            this.panel8.TabIndex = 24;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(92, 7);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 19);
            this.quantityTextBox.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(unitLabel);
            this.panel10.Controls.Add(unitCombobox);
            this.panel10.Location = new System.Drawing.Point(3, 178);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(295, 29);
            this.panel10.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.priceTextBox);
            this.panel6.Controls.Add(priceLabel);
            this.panel6.Location = new System.Drawing.Point(3, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 29);
            this.panel6.TabIndex = 23;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.priceTextBox.Location = new System.Drawing.Point(92, 6);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 19);
            this.priceTextBox.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.interestTextBox);
            this.panel4.Controls.Add(interestLabel);
            this.panel4.Location = new System.Drawing.Point(3, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 29);
            this.panel4.TabIndex = 23;
            // 
            // interestTextBox
            // 
            this.interestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importProductModelBindingSource, "Interest", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.interestTextBox.Location = new System.Drawing.Point(92, 7);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(200, 19);
            this.interestTextBox.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(supplierLabel);
            this.panel5.Controls.Add(this.supplierCombobox);
            this.panel5.Location = new System.Drawing.Point(3, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 29);
            this.panel5.TabIndex = 23;
            // 
            // supplierCombobox
            // 
            this.supplierCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.importProductModelBindingSource, "Supplier", true));
            this.supplierCombobox.DataSource = this.supplierBindingSource;
            this.supplierCombobox.DisplayMember = "Name";
            this.supplierCombobox.FormattingEnabled = true;
            this.supplierCombobox.Location = new System.Drawing.Point(92, 6);
            this.supplierCombobox.Name = "supplierCombobox";
            this.supplierCombobox.Size = new System.Drawing.Size(200, 20);
            this.supplierCombobox.TabIndex = 26;
            this.supplierCombobox.ValueMember = "Id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(SaleManager.Entities.Supplier);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exDateTimePicker);
            this.panel2.Controls.Add(exLabel);
            this.panel2.Location = new System.Drawing.Point(3, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 29);
            this.panel2.TabIndex = 22;
            // 
            // exDateTimePicker
            // 
            this.exDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.importProductModelBindingSource, "Ex", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.exDateTimePicker.Location = new System.Drawing.Point(92, 7);
            this.exDateTimePicker.Name = "exDateTimePicker";
            this.exDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.exDateTimePicker.TabIndex = 3;
            // 
            // FrmImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 439);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmImportProduct";
            this.Text = "ImportProduct";
            ((System.ComponentModel.ISupportInitialize)(this.importProductModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dgvData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.BindingSource importProductModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ex;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox priceBuyTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker exDateTimePicker;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.ComboBox supplierCombobox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace SaleManager.Views
{
    partial class FrmTransaction
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
            System.Windows.Forms.Label isPaymentLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label payBackLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label label3;
            this.dgvTransition = new System.Windows.Forms.DataGridView();
            this.transitionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbIsPayment = new System.Windows.Forms.CheckBox();
            this.ckbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ckbEnableDate = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.payBackTextBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            amountLabel = new System.Windows.Forms.Label();
            isPaymentLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            payBackLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionModelBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(13, 11);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(77, 14);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Thành tiền";
            // 
            // isPaymentLabel
            // 
            isPaymentLabel.AutoSize = true;
            isPaymentLabel.Location = new System.Drawing.Point(13, 12);
            isPaymentLabel.Name = "isPaymentLabel";
            isPaymentLabel.Size = new System.Drawing.Size(98, 14);
            isPaymentLabel.TabIndex = 6;
            isPaymentLabel.Text = "Đã thanh toán";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(13, 6);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(56, 14);
            noteLabel.TabIndex = 8;
            noteLabel.Text = "Ghi chú";
            // 
            // payBackLabel
            // 
            payBackLabel.AutoSize = true;
            payBackLabel.Location = new System.Drawing.Point(13, 17);
            payBackLabel.Name = "payBackLabel";
            payBackLabel.Size = new System.Drawing.Size(70, 14);
            payBackLabel.TabIndex = 10;
            payBackLabel.Text = "Còn thiếu";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(13, 14);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(49, 14);
            paymentLabel.TabIndex = 12;
            paymentLabel.Text = "Đã trả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 14);
            label3.TabIndex = 11;
            label3.Text = "Nhà PP";
            // 
            // dgvTransition
            // 
            this.dgvTransition.AllowUserToAddRows = false;
            this.dgvTransition.AllowUserToDeleteRows = false;
            this.dgvTransition.AutoGenerateColumns = false;
            this.dgvTransition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvTransition.DataSource = this.transitionModelBindingSource;
            this.dgvTransition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransition.Location = new System.Drawing.Point(0, 0);
            this.dgvTransition.Name = "dgvTransition";
            this.dgvTransition.ReadOnly = true;
            this.dgvTransition.RowTemplate.Height = 21;
            this.dgvTransition.Size = new System.Drawing.Size(792, 535);
            this.dgvTransition.TabIndex = 0;
            // 
            // transitionModelBindingSource
            // 
            this.transitionModelBindingSource.DataSource = typeof(SaleManager.Models.TransactionModel);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ckbIsPayment);
            this.panel4.Controls.Add(this.ckbType);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 36);
            this.panel4.TabIndex = 2;
            // 
            // ckbIsPayment
            // 
            this.ckbIsPayment.Checked = true;
            this.ckbIsPayment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIsPayment.Location = new System.Drawing.Point(217, 7);
            this.ckbIsPayment.Name = "ckbIsPayment";
            this.ckbIsPayment.Size = new System.Drawing.Size(153, 24);
            this.ckbIsPayment.TabIndex = 3;
            this.ckbIsPayment.Text = "Đã thanh toán";
            this.ckbIsPayment.UseVisualStyleBackColor = true;
            // 
            // ckbType
            // 
            this.ckbType.DisplayMember = "0,1";
            this.ckbType.FormattingEnabled = true;
            this.ckbType.Items.AddRange(new object[] {
            "Nhập hàng",
            "Bán hàng"});
            this.ckbType.Location = new System.Drawing.Point(79, 8);
            this.ckbType.Name = "ckbType";
            this.ckbType.Size = new System.Drawing.Size(121, 22);
            this.ckbType.TabIndex = 2;
            this.ckbType.ValueMember = "0,1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xuất/Nhập";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ckbEnableDate);
            this.panel5.Controls.Add(this.dtpTo);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dtpFrom);
            this.panel5.Location = new System.Drawing.Point(399, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 36);
            this.panel5.TabIndex = 3;
            // 
            // ckbEnableDate
            // 
            this.ckbEnableDate.AutoSize = true;
            this.ckbEnableDate.Location = new System.Drawing.Point(334, 12);
            this.ckbEnableDate.Name = "ckbEnableDate";
            this.ckbEnableDate.Size = new System.Drawing.Size(15, 14);
            this.ckbEnableDate.TabIndex = 3;
            this.ckbEnableDate.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(179, 8);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(139, 22);
            this.dtpTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "～";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(3, 8);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(139, 22);
            this.dtpFrom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(371, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(9, 6);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(364, 31);
            this.txtKey.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 92);
            this.panel2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1156, 627);
            this.splitContainer1.SplitterDistance = 792;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTransition);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 535);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 585);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(345, 85);
            this.panel11.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(isPaymentLabel);
            this.panel6.Location = new System.Drawing.Point(3, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(345, 39);
            this.panel6.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.transitionModelBindingSource, "IsPayment", true));
            this.checkBox1.Location = new System.Drawing.Point(117, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.amountTextBox);
            this.panel7.Controls.Add(amountLabel);
            this.panel7.Location = new System.Drawing.Point(3, 139);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(345, 39);
            this.panel7.TabIndex = 17;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transitionModelBindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.amountTextBox.Location = new System.Drawing.Point(117, 8);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(220, 22);
            this.amountTextBox.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.paymentTextBox);
            this.panel8.Controls.Add(paymentLabel);
            this.panel8.Location = new System.Drawing.Point(3, 184);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(345, 39);
            this.panel8.TabIndex = 18;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transitionModelBindingSource, "Payment", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.paymentTextBox.Location = new System.Drawing.Point(117, 6);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(220, 22);
            this.paymentTextBox.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.payBackTextBox);
            this.panel9.Controls.Add(payBackLabel);
            this.panel9.Location = new System.Drawing.Point(3, 229);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(345, 39);
            this.panel9.TabIndex = 17;
            // 
            // payBackTextBox
            // 
            this.payBackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transitionModelBindingSource, "PayBack", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.payBackTextBox.Location = new System.Drawing.Point(117, 9);
            this.payBackTextBox.Name = "payBackTextBox";
            this.payBackTextBox.Size = new System.Drawing.Size(220, 22);
            this.payBackTextBox.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(label3);
            this.panel10.Controls.Add(this.comboBox1);
            this.panel10.Location = new System.Drawing.Point(3, 274);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(345, 39);
            this.panel10.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transitionModelBindingSource, "SupplierId", true));
            this.comboBox1.DataSource = this.supplierBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(SaleManager.Entities.Supplier);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.noteTextBox);
            this.panel12.Controls.Add(noteLabel);
            this.panel12.Location = new System.Drawing.Point(3, 319);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(345, 99);
            this.panel12.TabIndex = 21;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transitionModelBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(117, 3);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(220, 93);
            this.noteTextBox.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnBack);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 585);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(360, 42);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(280, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Xuất/Nhập";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreateAt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày tạo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsPayment";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Thanh toán";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Payment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đã trả";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PayBack";
            this.dataGridViewTextBoxColumn4.HeaderText = "Trả lại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // FrmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 627);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTransaction";
            this.Text = "Quản lý giao dịch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionModelBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.BindingSource transitionModelBindingSource;
        private System.Windows.Forms.CheckBox ckbIsPayment;
        private System.Windows.Forms.ComboBox ckbType;
        private System.Windows.Forms.DataGridView dgvTransition;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.CheckBox ckbEnableDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox payBackTextBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
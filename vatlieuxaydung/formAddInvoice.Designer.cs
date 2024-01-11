namespace vatlieuxaydung
{
    partial class formAddInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddInvoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_maHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSet1 = new vatlieuxaydung.QLVATLIEUDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listItems = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dvt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.num_sl = new System.Windows.Forms.NumericUpDown();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.dgv_vl = new System.Windows.Forms.DataGridView();
            this.mavl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tenvl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kHACHHANGTableAdapter = new vatlieuxaydung.QLVATLIEUDataSet1TableAdapters.KHACHHANGTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_InsertInvoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vl)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createDatePicker);
            this.groupBox1.Controls.Add(this.txt_tenNV);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_maHoaDon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(980, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // createDatePicker
            // 
            this.createDatePicker.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createDatePicker.Location = new System.Drawing.Point(576, 24);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(253, 27);
            this.createDatePicker.TabIndex = 7;
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenNV.Location = new System.Drawing.Point(576, 90);
            this.txt_tenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.ReadOnly = true;
            this.txt_tenNV.Size = new System.Drawing.Size(253, 27);
            this.txt_tenNV.TabIndex = 5;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(180, 89);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.ReadOnly = true;
            this.txt_tenkh.Size = new System.Drawing.Size(253, 27);
            this.txt_tenkh.TabIndex = 4;
            // 
            // txt_maHoaDon
            // 
            this.txt_maHoaDon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHoaDon.Location = new System.Drawing.Point(180, 24);
            this.txt_maHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maHoaDon.Multiline = true;
            this.txt_maHoaDon.Name = "txt_maHoaDon";
            this.txt_maHoaDon.ReadOnly = true;
            this.txt_maHoaDon.Size = new System.Drawing.Size(253, 27);
            this.txt_maHoaDon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLVATLIEUDataSet1;
            // 
            // qLVATLIEUDataSet1
            // 
            this.qLVATLIEUDataSet1.DataSetName = "QLVATLIEUDataSet1";
            this.qLVATLIEUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listItems);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.removeBtn);
            this.groupBox2.Controls.Add(this.insertBtn);
            this.groupBox2.Controls.Add(this.num_sl);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.dgv_vl);
            this.groupBox2.Controls.Add(this.txt_tenvl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(11, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1196, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vật liệu";
            // 
            // listItems
            // 
            this.listItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.dvt,
            this.quantity,
            this.dongia,
            this.totalMoney});
            this.listItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listItems.GridLines = true;
            this.listItems.HideSelection = false;
            this.listItems.Location = new System.Drawing.Point(497, 39);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(688, 318);
            this.listItems.TabIndex = 38;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.View = System.Windows.Forms.View.Details;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Mã Vật Liệu";
            this.id.Width = 120;
            // 
            // name
            // 
            this.name.Text = "Tên Vật Liệu";
            this.name.Width = 120;
            // 
            // dvt
            // 
            this.dvt.Text = "Đơn Vị Tính";
            this.dvt.Width = 120;
            // 
            // quantity
            // 
            this.quantity.Text = "Số Lượng";
            this.quantity.Width = 120;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            this.dongia.Width = 120;
            // 
            // totalMoney
            // 
            this.totalMoney.Text = "Tổng Tiền";
            this.totalMoney.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(164, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "VNĐ";
            // 
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Location = new System.Drawing.Point(12, 318);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(147, 27);
            this.txt_price.TabIndex = 35;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Đơn giá";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.Location = new System.Drawing.Point(312, 269);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(99, 35);
            this.removeBtn.TabIndex = 32;
            this.removeBtn.Text = "   Bỏ";
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.insertBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Image = ((System.Drawing.Image)(resources.GetObject("insertBtn.Image")));
            this.insertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertBtn.Location = new System.Drawing.Point(312, 228);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(99, 35);
            this.insertBtn.TabIndex = 31;
            this.insertBtn.Text = " Thêm";
            this.insertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // num_sl
            // 
            this.num_sl.Location = new System.Drawing.Point(16, 251);
            this.num_sl.Name = "num_sl";
            this.num_sl.Size = new System.Drawing.Size(74, 27);
            this.num_sl.TabIndex = 28;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(213, 362);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(198, 27);
            this.txt_tongtien.TabIndex = 14;
            // 
            // dgv_vl
            // 
            this.dgv_vl.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavl,
            this.tenvatlieu});
            this.dgv_vl.Location = new System.Drawing.Point(11, 61);
            this.dgv_vl.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_vl.Name = "dgv_vl";
            this.dgv_vl.RowHeadersVisible = false;
            this.dgv_vl.RowHeadersWidth = 51;
            this.dgv_vl.RowTemplate.Height = 24;
            this.dgv_vl.Size = new System.Drawing.Size(400, 129);
            this.dgv_vl.TabIndex = 10;
            this.dgv_vl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vl_CellContentClick);
            // 
            // mavl
            // 
            this.mavl.HeaderText = "Mã Vật Liệu";
            this.mavl.Name = "mavl";
            this.mavl.ReadOnly = true;
            this.mavl.Width = 200;
            // 
            // tenvatlieu
            // 
            this.tenvatlieu.HeaderText = "Tên Vật Liệu";
            this.tenvatlieu.Name = "tenvatlieu";
            this.tenvatlieu.ReadOnly = true;
            this.tenvatlieu.Width = 200;
            // 
            // txt_tenvl
            // 
            this.txt_tenvl.Location = new System.Drawing.Point(11, 39);
            this.txt_tenvl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenvl.Name = "txt_tenvl";
            this.txt_tenvl.Size = new System.Drawing.Size(400, 27);
            this.txt_tenvl.TabIndex = 9;
            this.txt_tenvl.TextChanged += new System.EventHandler(this.txt_tenvl_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng số tiền hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn vật liệu";
            // 
            // price
            // 
            this.price.Text = "Đơn Giá";
            this.price.Width = 120;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1268, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1024, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "IN HOÁ ĐƠN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_InsertInvoice
            // 
            this.btn_InsertInvoice.BackColor = System.Drawing.Color.White;
            this.btn_InsertInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertInvoice.Image")));
            this.btn_InsertInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InsertInvoice.Location = new System.Drawing.Point(1024, 100);
            this.btn_InsertInvoice.Name = "btn_InsertInvoice";
            this.btn_InsertInvoice.Size = new System.Drawing.Size(172, 56);
            this.btn_InsertInvoice.TabIndex = 4;
            this.btn_InsertInvoice.Text = "     XUẤT HOÁ ĐƠN";
            this.btn_InsertInvoice.UseVisualStyleBackColor = false;
            this.btn_InsertInvoice.Click += new System.EventHandler(this.btn_InsertInvoice_Click);
            // 
            // formAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 556);
            this.Controls.Add(this.btn_InsertInvoice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAddInvoice";
            this.Text = "hoa_don";
            this.Load += new System.EventHandler(this.formAddInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vl)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.TextBox txt_maHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.DataGridView dgv_vl;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private QLVATLIEUDataSet1 qLVATLIEUDataSet1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLVATLIEUDataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.TextBox txt_tenvl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_InsertInvoice;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.NumericUpDown num_sl;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dvt;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvatlieu;
        private System.Windows.Forms.ColumnHeader totalMoney;
    }
}
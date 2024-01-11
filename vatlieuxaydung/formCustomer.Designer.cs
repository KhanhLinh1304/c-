namespace vatlieuxaydung
{
    partial class formCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddInvoice = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_dckh = new System.Windows.Forms.TextBox();
            this.txt_sdtkh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSet1 = new vatlieuxaydung.QLVATLIEUDataSet1();
            this.kHACHHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSet2 = new vatlieuxaydung.QLVATLIEUDataSet2();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qLVATLIEUDataSet = new vatlieuxaydung.QLVATLIEUDataSet();
            this.qLVATLIEUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new vatlieuxaydung.QLVATLIEUDataSet2TableAdapters.KHACHHANGTableAdapter();
            this.btn_ViewInvoice = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.kHACHHANGTableAdapter1 = new vatlieuxaydung.QLVATLIEUDataSet1TableAdapters.KHACHHANGTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddInvoice);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.txt_dckh);
            this.groupBox1.Controls.Add(this.txt_sdtkh);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(765, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm khách hàng";
            // 
            // btn_AddInvoice
            // 
            this.btn_AddInvoice.BackColor = System.Drawing.Color.White;
            this.btn_AddInvoice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AddInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddInvoice.Image")));
            this.btn_AddInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddInvoice.Location = new System.Drawing.Point(552, 131);
            this.btn_AddInvoice.Name = "btn_AddInvoice";
            this.btn_AddInvoice.Size = new System.Drawing.Size(198, 32);
            this.btn_AddInvoice.TabIndex = 12;
            this.btn_AddInvoice.Text = "Thêm Hoá Đơn";
            this.btn_AddInvoice.UseVisualStyleBackColor = false;
            this.btn_AddInvoice.Click += new System.EventHandler(this.btn_AddInvoice_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(552, 93);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(198, 32);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xoá Khách Hàng";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(552, 55);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(198, 32);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Cập Nhật Khách Hàng";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(552, 17);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(198, 32);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm Khách Hàng";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_dckh
            // 
            this.txt_dckh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dckh.Location = new System.Drawing.Point(322, 82);
            this.txt_dckh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dckh.Name = "txt_dckh";
            this.txt_dckh.Size = new System.Drawing.Size(167, 21);
            this.txt_dckh.TabIndex = 9;
            // 
            // txt_sdtkh
            // 
            this.txt_sdtkh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtkh.Location = new System.Drawing.Point(322, 28);
            this.txt_sdtkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdtkh.Name = "txt_sdtkh";
            this.txt_sdtkh.ReadOnly = true;
            this.txt_sdtkh.Size = new System.Drawing.Size(167, 21);
            this.txt_sdtkh.TabIndex = 8;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(74, 80);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(145, 21);
            this.txt_tenkh.TabIndex = 7;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(74, 28);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.ReadOnly = true;
            this.txt_makh.Size = new System.Drawing.Size(145, 21);
            this.txt_makh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tìm kiếm khách hàng theo số điện thoại";
            // 
            // dgv_customer
            // 
            this.dgv_customer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.sdt,
            this.diachi});
            this.dgv_customer.Location = new System.Drawing.Point(27, 275);
            this.dgv_customer.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 24;
            this.dgv_customer.Size = new System.Drawing.Size(706, 165);
            this.dgv_customer.TabIndex = 5;
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            this.dgv_customer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentDoubleClick);
            // 
            // makh
            // 
            this.makh.HeaderText = "Mã Khách Hàng";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 200;
            // 
            // tenkh
            // 
            this.tenkh.HeaderText = "Tên Khách Hàng";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            this.tenkh.Width = 200;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 200;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // kHACHHANGBindingSource2
            // 
            this.kHACHHANGBindingSource2.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource2.DataSource = this.qLVATLIEUDataSet1;
            // 
            // qLVATLIEUDataSet1
            // 
            this.qLVATLIEUDataSet1.DataSetName = "QLVATLIEUDataSet1";
            this.qLVATLIEUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource1
            // 
            this.kHACHHANGBindingSource1.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource1.DataSource = this.qLVATLIEUDataSet2BindingSource;
            // 
            // qLVATLIEUDataSet2BindingSource
            // 
            this.qLVATLIEUDataSet2BindingSource.DataSource = this.qLVATLIEUDataSet2;
            this.qLVATLIEUDataSet2BindingSource.Position = 0;
            // 
            // qLVATLIEUDataSet2
            // 
            this.qLVATLIEUDataSet2.DataSetName = "QLVATLIEUDataSet2";
            this.qLVATLIEUDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(59, 237);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(212, 21);
            this.txt_search.TabIndex = 10;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 21);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // qLVATLIEUDataSet
            // 
            this.qLVATLIEUDataSet.DataSetName = "QLVATLIEUDataSet";
            this.qLVATLIEUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLVATLIEUDataSetBindingSource
            // 
            this.qLVATLIEUDataSetBindingSource.DataSource = this.qLVATLIEUDataSet;
            this.qLVATLIEUDataSetBindingSource.Position = 0;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLVATLIEUDataSet2BindingSource;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ViewInvoice
            // 
            this.btn_ViewInvoice.BackColor = System.Drawing.Color.White;
            this.btn_ViewInvoice.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewInvoice.Image")));
            this.btn_ViewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewInvoice.Location = new System.Drawing.Point(591, 219);
            this.btn_ViewInvoice.Name = "btn_ViewInvoice";
            this.btn_ViewInvoice.Size = new System.Drawing.Size(142, 51);
            this.btn_ViewInvoice.TabIndex = 12;
            this.btn_ViewInvoice.Text = "XEM HOÁ ĐƠN";
            this.btn_ViewInvoice.UseVisualStyleBackColor = false;
            this.btn_ViewInvoice.Click += new System.EventHandler(this.btn_ViewInvoice_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.Location = new System.Drawing.Point(444, 219);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(141, 51);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "LÀM MỚI DỮ LIỆU";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // kHACHHANGTableAdapter1
            // 
            this.kHACHHANGTableAdapter1.ClearBeforeFill = true;
            // 
            // formCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 491);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_ViewInvoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_customer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCustomer";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.formCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dckh;
        private System.Windows.Forms.TextBox txt_sdtkh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label1;
        private QLVATLIEUDataSet qLVATLIEUDataSet;
        private System.Windows.Forms.BindingSource qLVATLIEUDataSetBindingSource;
        private QLVATLIEUDataSet1 qLVATLIEUDataSet1;
        private QLVATLIEUDataSet2 qLVATLIEUDataSet2;
        private System.Windows.Forms.BindingSource qLVATLIEUDataSet2BindingSource;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLVATLIEUDataSet2TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource1;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource2;
        private QLVATLIEUDataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter1;
        private System.Windows.Forms.Button btn_ViewInvoice;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_AddInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}
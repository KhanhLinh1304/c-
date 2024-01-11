namespace vatlieuxaydung
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_VL = new System.Windows.Forms.DataGridView();
            this.maVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txt_tenVL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbx_maVL = new System.Windows.Forms.ComboBox();
            this.lOAIVATLIEUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEU1DataSet = new vatlieuxaydung.QLVATLIEU1DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_xinchao = new System.Windows.Forms.Label();
            this.lOAIVATLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSet = new vatlieuxaydung.QLVATLIEUDataSet();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoaiVatLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOAIVATLIEUTableAdapter = new vatlieuxaydung.QLVATLIEUDataSetTableAdapters.LOAIVATLIEUTableAdapter();
            this.khachhangTableAdapter1 = new vatlieuxaydung.QLVATLIEUDataSet2TableAdapters.KHACHHANGTableAdapter();
            this.lOAIVATLIEUTableAdapter1 = new vatlieuxaydung.QLVATLIEU1DataSetTableAdapters.LOAIVATLIEUTableAdapter();
            this.lOAIVATLIEUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qlvatlieuDataSet1 = new vatlieuxaydung.QLVATLIEUDataSet();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VL)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEU1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvatlieuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 722);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "CỬA HÀNG QUẢN LÝ VẬT LIỆU XÂY DỰNG HL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_reload);
            this.groupBox4.Controls.Add(this.btn_insert);
            this.groupBox4.Location = new System.Drawing.Point(826, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 79);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cập Nhật ";
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.White;
            this.btn_reload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reload.Location = new System.Drawing.Point(192, 22);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(170, 42);
            this.btn_reload.TabIndex = 1;
            this.btn_reload.Text = "    Làm Mới Dữ Liệu";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(16, 22);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(170, 42);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Thêm Vật Liệu";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_VL);
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1200, 428);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản Lí Vật Liệu";
            // 
            // dgv_VL
            // 
            this.dgv_VL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VL.BackgroundColor = System.Drawing.Color.White;
            this.dgv_VL.ColumnHeadersHeight = 30;
            this.dgv_VL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVL,
            this.tenVL,
            this.dongia,
            this.donViTinh,
            this.soluong,
            this.loaiVL});
            this.dgv_VL.Location = new System.Drawing.Point(6, 22);
            this.dgv_VL.Name = "dgv_VL";
            this.dgv_VL.ReadOnly = true;
            this.dgv_VL.RowHeadersWidth = 45;
            this.dgv_VL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VL.Size = new System.Drawing.Size(1188, 403);
            this.dgv_VL.TabIndex = 0;
            this.dgv_VL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VL_CellDoubleClick);
            // 
            // maVL
            // 
            this.maVL.HeaderText = "Mã Vật Liệu";
            this.maVL.Name = "maVL";
            this.maVL.ReadOnly = true;
            // 
            // tenVL
            // 
            this.tenVL.HeaderText = "Tên Vật Liệu";
            this.tenVL.Name = "tenVL";
            this.tenVL.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // donViTinh
            // 
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // loaiVL
            // 
            this.loaiVL.HeaderText = "Loại Vật Liệu";
            this.loaiVL.Name = "loaiVL";
            this.loaiVL.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconPictureBox1);
            this.groupBox2.Controls.Add(this.txt_tenVL);
            this.groupBox2.Location = new System.Drawing.Point(365, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 55);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Theo Vật Liệu";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(35, 25);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // txt_tenVL
            // 
            this.txt_tenVL.Location = new System.Drawing.Point(61, 22);
            this.txt_tenVL.Name = "txt_tenVL";
            this.txt_tenVL.Size = new System.Drawing.Size(357, 23);
            this.txt_tenVL.TabIndex = 0;
            this.txt_tenVL.TextChanged += new System.EventHandler(this.txt_tenVL_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbx_maVL);
            this.groupBox1.Location = new System.Drawing.Point(26, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Vật Liệu";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(231, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "LỌC";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbx_maVL
            // 
            this.cbx_maVL.DataSource = this.lOAIVATLIEUBindingSource1;
            this.cbx_maVL.DisplayMember = "TENLOAIVATLIEU";
            this.cbx_maVL.FormattingEnabled = true;
            this.cbx_maVL.Location = new System.Drawing.Point(19, 24);
            this.cbx_maVL.Name = "cbx_maVL";
            this.cbx_maVL.Size = new System.Drawing.Size(206, 25);
            this.cbx_maVL.TabIndex = 0;
            this.cbx_maVL.ValueMember = "MALOAIVATLIEU";
            this.cbx_maVL.SelectedIndexChanged += new System.EventHandler(this.cbx_maVL_SelectedIndexChanged);
            // 
            // lOAIVATLIEUBindingSource1
            // 
            this.lOAIVATLIEUBindingSource1.DataMember = "LOAIVATLIEU";
            this.lOAIVATLIEUBindingSource1.DataSource = this.qLVATLIEU1DataSet;
            // 
            // qLVATLIEU1DataSet
            // 
            this.qLVATLIEU1DataSet.DataSetName = "QLVATLIEU1DataSet";
            this.qLVATLIEU1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_date);
            this.panel2.Controls.Add(this.lb_xinchao);
            this.panel2.Location = new System.Drawing.Point(94, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 63);
            this.panel2.TabIndex = 8;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(13, 31);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(299, 20);
            this.lb_date.TabIndex = 13;
            this.lb_date.Text = "hôm nay là ngày 20 tháng 12 năm 2022";
            // 
            // lb_xinchao
            // 
            this.lb_xinchao.AutoSize = true;
            this.lb_xinchao.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xinchao.Location = new System.Drawing.Point(10, 10);
            this.lb_xinchao.Name = "lb_xinchao";
            this.lb_xinchao.Size = new System.Drawing.Size(101, 20);
            this.lb_xinchao.TabIndex = 12;
            this.lb_xinchao.Text = "chào admin!";
            // 
            // lOAIVATLIEUBindingSource
            // 
            this.lOAIVATLIEUBindingSource.DataMember = "LOAIVATLIEU";
            this.lOAIVATLIEUBindingSource.DataSource = this.qLVATLIEUDataSetBindingSource;
            // 
            // qLVATLIEUDataSetBindingSource
            // 
            this.qLVATLIEUDataSetBindingSource.DataSource = this.qLVATLIEUDataSet;
            this.qLVATLIEUDataSetBindingSource.Position = 0;
            // 
            // qLVATLIEUDataSet
            // 
            this.qLVATLIEUDataSet.DataSetName = "QLVATLIEUDataSet";
            this.qLVATLIEUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoaiVatLieuToolStripMenuItem,
            this.KhachHangToolStripMenuItem,
            this.HoaDonToolStripMenuItem,
            this.ThongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoaiVatLieuToolStripMenuItem
            // 
            this.LoaiVatLieuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.LoaiVatLieuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoaiVatLieuToolStripMenuItem.Image")));
            this.LoaiVatLieuToolStripMenuItem.Name = "LoaiVatLieuToolStripMenuItem";
            this.LoaiVatLieuToolStripMenuItem.Size = new System.Drawing.Size(153, 23);
            this.LoaiVatLieuToolStripMenuItem.Text = "LOẠI VẬT LIỆU";
            this.LoaiVatLieuToolStripMenuItem.Click += new System.EventHandler(this.LoaiVatLieuToolStripMenuItem_Click);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.CheckOnClick = true;
            this.KhachHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.KhachHangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("KhachHangToolStripMenuItem.Image")));
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(146, 23);
            this.KhachHangToolStripMenuItem.Text = "KHÁCH HÀNG";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // HoaDonToolStripMenuItem
            // 
            this.HoaDonToolStripMenuItem.CheckOnClick = true;
            this.HoaDonToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HoaDonToolStripMenuItem.Image")));
            this.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem";
            this.HoaDonToolStripMenuItem.Size = new System.Drawing.Size(149, 23);
            this.HoaDonToolStripMenuItem.Text = "TẠO HOÁ ĐƠN";
            this.HoaDonToolStripMenuItem.Click += new System.EventHandler(this.HoaDonToolStripMenuItem_Click);
            // 
            // ThongKeToolStripMenuItem
            // 
            this.ThongKeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ThongKeToolStripMenuItem.Image")));
            this.ThongKeToolStripMenuItem.Name = "ThongKeToolStripMenuItem";
            this.ThongKeToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.ThongKeToolStripMenuItem.Text = "THỐNG KÊ";
            this.ThongKeToolStripMenuItem.Click += new System.EventHandler(this.ThongKeToolStripMenuItem_Click);
            // 
            // lOAIVATLIEUTableAdapter
            // 
            this.lOAIVATLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // khachhangTableAdapter1
            // 
            this.khachhangTableAdapter1.ClearBeforeFill = true;
            // 
            // lOAIVATLIEUTableAdapter1
            // 
            this.lOAIVATLIEUTableAdapter1.ClearBeforeFill = true;
            // 
            // lOAIVATLIEUBindingSource2
            // 
            this.lOAIVATLIEUBindingSource2.DataMember = "LOAIVATLIEU";
            this.lOAIVATLIEUBindingSource2.DataSource = this.qLVATLIEUDataSetBindingSource;
            // 
            // qlvatlieuDataSet1
            // 
            this.qlvatlieuDataSet1.DataSetName = "QLVATLIEUDataSet";
            this.qlvatlieuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quản lý vật liệu";
            this.Load += new System.EventHandler(this.trang_chinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEU1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvatlieuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LoaiVatLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongKeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_xinchao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_VL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbx_maVL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txt_tenVL;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource qLVATLIEUDataSetBindingSource;
        private QLVATLIEUDataSet qLVATLIEUDataSet;
        private System.Windows.Forms.BindingSource lOAIVATLIEUBindingSource;
        private QLVATLIEUDataSetTableAdapters.LOAIVATLIEUTableAdapter lOAIVATLIEUTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiVL;
        private QLVATLIEUDataSet2TableAdapters.KHACHHANGTableAdapter khachhangTableAdapter1;
        private QLVATLIEU1DataSet qLVATLIEU1DataSet;
        private System.Windows.Forms.BindingSource lOAIVATLIEUBindingSource1;
        private QLVATLIEU1DataSetTableAdapters.LOAIVATLIEUTableAdapter lOAIVATLIEUTableAdapter1;
        private System.Windows.Forms.BindingSource lOAIVATLIEUBindingSource2;
        private QLVATLIEUDataSet qlvatlieuDataSet1;
    }
}


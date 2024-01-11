namespace vatlieuxaydung
{
    partial class formViewInvoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_tenKH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_mahoadon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_chitietHD = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mahoadon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_diachi);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.lb_tenKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(238, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(538, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(14, 93);
            this.lb_diachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(47, 13);
            this.lb_diachi.TabIndex = 2;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(14, 63);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(83, 13);
            this.lb_sdt.TabIndex = 1;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_tenKH
            // 
            this.lb_tenKH.AutoSize = true;
            this.lb_tenKH.Location = new System.Drawing.Point(14, 29);
            this.lb_tenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenKH.Name = "lb_tenKH";
            this.lb_tenKH.Size = new System.Drawing.Size(75, 13);
            this.lb_tenKH.TabIndex = 0;
            this.lb_tenKH.Text = "Khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_mahoadon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(369, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgv_mahoadon
            // 
            this.dgv_mahoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_mahoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mahoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.total,
            this.tenNV});
            this.dgv_mahoadon.Location = new System.Drawing.Point(4, 12);
            this.dgv_mahoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_mahoadon.Name = "dgv_mahoadon";
            this.dgv_mahoadon.RowHeadersVisible = false;
            this.dgv_mahoadon.RowHeadersWidth = 51;
            this.dgv_mahoadon.RowTemplate.Height = 24;
            this.dgv_mahoadon.Size = new System.Drawing.Size(358, 202);
            this.dgv_mahoadon.TabIndex = 0;
            this.dgv_mahoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mahoadon_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_chitietHD);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(408, 164);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(564, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dgv_chitietHD
            // 
            this.dgv_chitietHD.BackgroundColor = System.Drawing.Color.White;
            this.dgv_chitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVL,
            this.tenVL,
            this.soluong,
            this.thanhtien,
            this.donvitinh});
            this.dgv_chitietHD.Location = new System.Drawing.Point(30, 16);
            this.dgv_chitietHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_chitietHD.Name = "dgv_chitietHD";
            this.dgv_chitietHD.RowHeadersWidth = 51;
            this.dgv_chitietHD.RowTemplate.Height = 24;
            this.dgv_chitietHD.Size = new System.Drawing.Size(505, 196);
            this.dgv_chitietHD.TabIndex = 0;
            // 
            // maHD
            // 
            this.maHD.HeaderText = "Mã Hoá Đơn";
            this.maHD.Name = "maHD";
            this.maHD.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "Tổng Tiền";
            this.total.Name = "total";
            // 
            // tenNV
            // 
            this.tenNV.HeaderText = "Tên Nhân Viên";
            this.tenNV.Name = "tenNV";
            // 
            // maVL
            // 
            this.maVL.HeaderText = "Mã Vật Liệu";
            this.maVL.Name = "maVL";
            this.maVL.Width = 50;
            // 
            // tenVL
            // 
            this.tenVL.HeaderText = "Tên Vật Liệu";
            this.tenVL.Name = "tenVL";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // donvitinh
            // 
            this.donvitinh.HeaderText = "Đơn Vị Tính";
            this.donvitinh.Name = "donvitinh";
            // 
            // formViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formViewInvoice";
            this.Text = "man_hinh_hoa_don";
            this.Load += new System.EventHandler(this.formViewInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mahoadon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_tenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_mahoadon;
        private System.Windows.Forms.DataGridView dgv_chitietHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
    }
}
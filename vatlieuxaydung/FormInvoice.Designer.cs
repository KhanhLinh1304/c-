namespace vatlieuxaydung
{
    partial class FormInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_maDH = new System.Windows.Forms.Label();
            this.lB_time = new System.Windows.Forms.Label();
            this.lb_tenNV = new System.Windows.Forms.Label();
            this.lb_diachiKH = new System.Windows.Forms.Label();
            this.lB_sdtKH = new System.Windows.Forms.Label();
            this.lb_tenKH = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.tenvl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donvitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lb_maDH);
            this.groupBox1.Controls.Add(this.lB_time);
            this.groupBox1.Controls.Add(this.lb_tenNV);
            this.groupBox1.Controls.Add(this.lb_diachiKH);
            this.groupBox1.Controls.Add(this.lB_sdtKH);
            this.groupBox1.Controls.Add(this.lb_tenKH);
            this.groupBox1.Location = new System.Drawing.Point(53, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // lb_maDH
            // 
            this.lb_maDH.AutoSize = true;
            this.lb_maDH.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maDH.Location = new System.Drawing.Point(322, 28);
            this.lb_maDH.Name = "lb_maDH";
            this.lb_maDH.Size = new System.Drawing.Size(118, 18);
            this.lb_maDH.TabIndex = 2;
            this.lb_maDH.Text = "MÃ ĐƠN HÀNG:";
            // 
            // lB_time
            // 
            this.lB_time.AutoSize = true;
            this.lB_time.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_time.Location = new System.Drawing.Point(322, 51);
            this.lB_time.Name = "lB_time";
            this.lB_time.Size = new System.Drawing.Size(147, 18);
            this.lB_time.TabIndex = 4;
            this.lB_time.Text = "Thời Gian Bán Hàng";
            // 
            // lb_tenNV
            // 
            this.lb_tenNV.AutoSize = true;
            this.lb_tenNV.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenNV.Location = new System.Drawing.Point(322, 76);
            this.lb_tenNV.Name = "lb_tenNV";
            this.lb_tenNV.Size = new System.Drawing.Size(158, 18);
            this.lb_tenNV.TabIndex = 3;
            this.lb_tenNV.Text = "Nhân Viên Bán Hàng:";
            // 
            // lb_diachiKH
            // 
            this.lb_diachiKH.AutoSize = true;
            this.lb_diachiKH.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachiKH.Location = new System.Drawing.Point(43, 76);
            this.lb_diachiKH.Name = "lb_diachiKH";
            this.lb_diachiKH.Size = new System.Drawing.Size(63, 18);
            this.lb_diachiKH.TabIndex = 2;
            this.lb_diachiKH.Text = "Địa Chỉ:";
            // 
            // lB_sdtKH
            // 
            this.lB_sdtKH.AutoSize = true;
            this.lB_sdtKH.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_sdtKH.Location = new System.Drawing.Point(43, 51);
            this.lB_sdtKH.Name = "lB_sdtKH";
            this.lB_sdtKH.Size = new System.Drawing.Size(117, 18);
            this.lB_sdtKH.TabIndex = 1;
            this.lB_sdtKH.Text = "Số Điện Thoại: ";
            // 
            // lb_tenKH
            // 
            this.lb_tenKH.AutoSize = true;
            this.lb_tenKH.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenKH.Location = new System.Drawing.Point(43, 28);
            this.lb_tenKH.Name = "lb_tenKH";
            this.lb_tenKH.Size = new System.Drawing.Size(98, 18);
            this.lb_tenKH.TabIndex = 0;
            this.lb_tenKH.Text = "Khách Hàng:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenvl,
            this.donvitinh,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(53, 230);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(695, 178);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tenvl
            // 
            this.tenvl.Text = "Tên Vật Liệu";
            // 
            // donvitinh
            // 
            this.donvitinh.Text = "Đơn Vị Tính";
            // 
            // soluong
            // 
            this.soluong.Text = "Số Lượng";
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            // 
            // thanhtien
            // 
            this.thanhtien.Text = "Thành Tiền";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.Location = new System.Drawing.Point(490, 425);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(76, 18);
            this.lb_tongtien.TabIndex = 3;
            this.lb_tongtien.Text = "Tổng Tiền";
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_maDH;
        private System.Windows.Forms.Label lB_time;
        private System.Windows.Forms.Label lb_tenNV;
        private System.Windows.Forms.Label lb_diachiKH;
        private System.Windows.Forms.Label lB_sdtKH;
        private System.Windows.Forms.Label lb_tenKH;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.ColumnHeader tenvl;
        private System.Windows.Forms.ColumnHeader donvitinh;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader dongia;
        private System.Windows.Forms.ColumnHeader thanhtien;
    }
}
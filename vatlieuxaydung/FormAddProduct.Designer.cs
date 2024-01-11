namespace vatlieuxaydung
{
    partial class FormAddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.dgv_vatlieu = new System.Windows.Forms.DataGridView();
            this.tenVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SaveDB = new System.Windows.Forms.Button();
            this.btn_ReadExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vatlieu
            // 
            this.dgv_vatlieu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vatlieu.ColumnHeadersHeight = 25;
            this.dgv_vatlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenVL,
            this.dongia,
            this.soluong,
            this.loaiVL,
            this.donvitinh});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vatlieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vatlieu.Location = new System.Drawing.Point(12, 86);
            this.dgv_vatlieu.Name = "dgv_vatlieu";
            this.dgv_vatlieu.RowHeadersWidth = 20;
            this.dgv_vatlieu.Size = new System.Drawing.Size(783, 209);
            this.dgv_vatlieu.TabIndex = 2;
            // 
            // tenVL
            // 
            this.tenVL.HeaderText = "Tên Vật Liệu";
            this.tenVL.Name = "tenVL";
            this.tenVL.Width = 150;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.Width = 150;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 150;
            // 
            // loaiVL
            // 
            this.loaiVL.HeaderText = "Loại Vật Liệu";
            this.loaiVL.Name = "loaiVL";
            this.loaiVL.Width = 150;
            // 
            // donvitinh
            // 
            this.donvitinh.HeaderText = "Đơn Vị Tính";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Width = 150;
            // 
            // btn_SaveDB
            // 
            this.btn_SaveDB.BackColor = System.Drawing.Color.White;
            this.btn_SaveDB.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveDB.Image")));
            this.btn_SaveDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveDB.Location = new System.Drawing.Point(453, 26);
            this.btn_SaveDB.Name = "btn_SaveDB";
            this.btn_SaveDB.Size = new System.Drawing.Size(195, 45);
            this.btn_SaveDB.TabIndex = 1;
            this.btn_SaveDB.Text = "Thêm Vào Cơ Sở Dữ Liệu";
            this.btn_SaveDB.UseVisualStyleBackColor = false;
            this.btn_SaveDB.Click += new System.EventHandler(this.btn_SaveDB_Click);
            // 
            // btn_ReadExcel
            // 
            this.btn_ReadExcel.BackColor = System.Drawing.Color.White;
            this.btn_ReadExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReadExcel.Image")));
            this.btn_ReadExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReadExcel.Location = new System.Drawing.Point(183, 26);
            this.btn_ReadExcel.Name = "btn_ReadExcel";
            this.btn_ReadExcel.Size = new System.Drawing.Size(195, 45);
            this.btn_ReadExcel.TabIndex = 0;
            this.btn_ReadExcel.Text = "Đọc Dữ LiệuTừ File Excel";
            this.btn_ReadExcel.UseVisualStyleBackColor = false;
            this.btn_ReadExcel.Click += new System.EventHandler(this.btn_ReadExcel_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.dgv_vatlieu);
            this.Controls.Add(this.btn_SaveDB);
            this.Controls.Add(this.btn_ReadExcel);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vatlieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ReadExcel;
        private System.Windows.Forms.Button btn_SaveDB;
        private System.Windows.Forms.DataGridView dgv_vatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
    }
}
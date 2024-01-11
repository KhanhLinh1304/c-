namespace vatlieuxaydung
{
    partial class formReport
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
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.maVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(89, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(140, 28);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(106, 19);
            this.toDate.TabIndex = 4;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(15, 28);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(109, 19);
            this.startDate.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(50, 68);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(138, 33);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "XEM DOANH THU";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dgv_report
            // 
            this.dgv_report.BackgroundColor = System.Drawing.Color.White;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVL,
            this.tenVL,
            this.soluong,
            this.tongtien});
            this.dgv_report.Location = new System.Drawing.Point(22, 155);
            this.dgv_report.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.RowHeadersWidth = 51;
            this.dgv_report.RowTemplate.Height = 24;
            this.dgv_report.Size = new System.Drawing.Size(726, 201);
            this.dgv_report.TabIndex = 4;
            // 
            // maVL
            // 
            this.maVL.HeaderText = "Mã Vật Liệu";
            this.maVL.Name = "maVL";
            // 
            // tenVL
            // 
            this.tenVL.HeaderText = "Tên Vật Liệu";
            this.tenVL.Name = "tenVL";
            this.tenVL.Width = 200;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng ";
            this.soluong.Name = "soluong";
            this.soluong.Width = 200;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 200;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(429, 128);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(56, 13);
            this.lb_tongtien.TabIndex = 5;
            this.lb_tongtien.Text = "Tổng Tiền";
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 386);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formReport";
            this.Text = "thong_ke";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.Label lb_tongtien;
    }
}
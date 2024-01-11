namespace vatlieuxaydung
{
    partial class formStockReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStockReceive));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_maVL = new System.Windows.Forms.Label();
            this.txt_tenVL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_soluong);
            this.panel1.Controls.Add(this.txt_maVL);
            this.panel1.Controls.Add(this.txt_tenVL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 128);
            this.panel1.TabIndex = 0;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(149, 81);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(122, 18);
            this.txt_soluong.TabIndex = 3;
            // 
            // txt_maVL
            // 
            this.txt_maVL.AutoSize = true;
            this.txt_maVL.Location = new System.Drawing.Point(146, 28);
            this.txt_maVL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_maVL.Name = "txt_maVL";
            this.txt_maVL.Size = new System.Drawing.Size(35, 13);
            this.txt_maVL.TabIndex = 2;
            this.txt_maVL.Text = "label3";
            // 
            // txt_tenVL
            // 
            this.txt_tenVL.AutoSize = true;
            this.txt_tenVL.Location = new System.Drawing.Point(146, 53);
            this.txt_tenVL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_tenVL.Name = "txt_tenVL";
            this.txt_tenVL.Size = new System.Drawing.Size(35, 13);
            this.txt_tenVL.TabIndex = 2;
            this.txt_tenVL.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Vật Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên vật liệu";
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NhapHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapHang.Image")));
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Location = new System.Drawing.Point(89, 172);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(151, 56);
            this.btn_NhapHang.TabIndex = 1;
            this.btn_NhapHang.Text = "         NHẬP HÀNG";
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // nhapKho_vat_lieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 274);
            this.Controls.Add(this.btn_NhapHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "nhapKho_vat_lieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập Kho Vật Liệu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label txt_tenVL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_maVL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_NhapHang;
    }
}
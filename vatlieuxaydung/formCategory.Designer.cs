namespace vatlieuxaydung
{
    partial class formCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCategory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_tenloaivl = new System.Windows.Forms.TextBox();
            this.txt_maloaivl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_loaiVL = new System.Windows.Forms.DataGridView();
            this.maloaivl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaivl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIVATLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVATLIEUDataSet = new vatlieuxaydung.QLVATLIEUDataSet();
            this.lOAIVATLIEUTableAdapter = new vatlieuxaydung.QLVATLIEUDataSetTableAdapters.LOAIVATLIEUTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.txt_tenloaivl);
            this.groupBox1.Controls.Add(this.txt_maloaivl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(575, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(442, 96);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 33);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(442, 57);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 33);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(443, 18);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(114, 33);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_tenloaivl
            // 
            this.txt_tenloaivl.Location = new System.Drawing.Point(142, 69);
            this.txt_tenloaivl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenloaivl.Name = "txt_tenloaivl";
            this.txt_tenloaivl.Size = new System.Drawing.Size(132, 19);
            this.txt_tenloaivl.TabIndex = 3;
            // 
            // txt_maloaivl
            // 
            this.txt_maloaivl.Location = new System.Drawing.Point(142, 32);
            this.txt_maloaivl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maloaivl.Name = "txt_maloaivl";
            this.txt_maloaivl.Size = new System.Drawing.Size(132, 19);
            this.txt_maloaivl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại Vật Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Vật Liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_loaiVL);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(577, 191);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại vật liệu";
            // 
            // dgv_loaiVL
            // 
            this.dgv_loaiVL.AllowUserToResizeRows = false;
            this.dgv_loaiVL.AutoGenerateColumns = false;
            this.dgv_loaiVL.BackgroundColor = System.Drawing.Color.White;
            this.dgv_loaiVL.ColumnHeadersHeight = 50;
            this.dgv_loaiVL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaivl,
            this.tenloaivl});
            this.dgv_loaiVL.DataSource = this.lOAIVATLIEUBindingSource;
            this.dgv_loaiVL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_loaiVL.Location = new System.Drawing.Point(2, 14);
            this.dgv_loaiVL.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_loaiVL.Name = "dgv_loaiVL";
            this.dgv_loaiVL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_loaiVL.RowHeadersWidth = 80;
            this.dgv_loaiVL.RowTemplate.Height = 24;
            this.dgv_loaiVL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaiVL.Size = new System.Drawing.Size(573, 175);
            this.dgv_loaiVL.TabIndex = 0;
            this.dgv_loaiVL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiVL_CellClick);
            this.dgv_loaiVL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiVL_CellContentClick);
            // 
            // maloaivl
            // 
            this.maloaivl.DataPropertyName = "MALOAIVATLIEU";
            this.maloaivl.HeaderText = "Mã Loại Vật Liệu";
            this.maloaivl.Name = "maloaivl";
            this.maloaivl.Width = 250;
            // 
            // tenloaivl
            // 
            this.tenloaivl.DataPropertyName = "TENLOAIVATLIEU";
            this.tenloaivl.HeaderText = "Tên Loại Vật Liệu";
            this.tenloaivl.Name = "tenloaivl";
            this.tenloaivl.Width = 250;
            // 
            // lOAIVATLIEUBindingSource
            // 
            this.lOAIVATLIEUBindingSource.DataMember = "LOAIVATLIEU";
            this.lOAIVATLIEUBindingSource.DataSource = this.qLVATLIEUDataSet;
            // 
            // qLVATLIEUDataSet
            // 
            this.qLVATLIEUDataSet.DataSetName = "QLVATLIEUDataSet";
            this.qLVATLIEUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIVATLIEUTableAdapter
            // 
            this.lOAIVATLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(9, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm ";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(428, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 28);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.txt_search.Location = new System.Drawing.Point(104, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(318, 27);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // formCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách loại vật liệu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIVATLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVATLIEUDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenloaivl;
        private System.Windows.Forms.TextBox txt_maloaivl;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private QLVATLIEUDataSet qLVATLIEUDataSet;
        private System.Windows.Forms.BindingSource lOAIVATLIEUBindingSource;
        private QLVATLIEUDataSetTableAdapters.LOAIVATLIEUTableAdapter lOAIVATLIEUTableAdapter;
        private System.Windows.Forms.DataGridView dgv_loaiVL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaivl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaivl;
    }
}
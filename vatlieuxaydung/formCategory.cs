using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vatlieuxaydung
{
    public partial class formCategory : Form
    {
        CategoryBUS categoryBUS = new CategoryBUS();
        public formCategory()
        {
            InitializeComponent();
        }
        public void ResetData()
        {
            txt_tenloaivl.Text = "";
            txt_maloaivl.Text = "";
        }
        public void loadData()
        {
            this.lOAIVATLIEUTableAdapter.Fill(this.qLVATLIEUDataSet.LOAIVATLIEU);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(txt_maloaivl.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã Loại Vật Liệu","cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else if(txt_tenloaivl.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên Loại Vật Liệu","cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maloaivl = txt_maloaivl.Text;
                string tenloaivl = txt_tenloaivl.Text;
                Category category = new Category(maloaivl, tenloaivl);
                categoryBUS.insertCategory(category);
                ResetData();
                loadData();
                MessageBox.Show("Thêm Loại Vật Liệu Thành Công","thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            


        }

        private void dgv_loaiVL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_loaiVL.Columns)
            {
                column.ReadOnly = true;
            }
            int rowIndex = e.RowIndex; 
            if(rowIndex >= 0 && rowIndex < dgv_loaiVL.Rows.Count) {
                DataGridViewRow selectedRow = dgv_loaiVL.Rows[rowIndex];
                string id = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                txt_maloaivl.Text = id;
                txt_tenloaivl.Text = name;
            }
            btn_insert.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_maloaivl.Text;
            if(id == "")
            {
                MessageBox.Show("Bạn chưa chọn loại vật liệu để xoá", "cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                categoryBUS.deleteCategory(id);
                loadData();
                ResetData();
                MessageBox.Show("Xoá Thành Công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string maloaivl = txt_maloaivl.Text;
            string tenloaivl = txt_tenloaivl.Text;
            if(maloaivl == "")
            {
                MessageBox.Show("Bạn chưa chọn loại vật liệu để cập nhật", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(tenloaivl == "")
                {
                    MessageBox.Show("Tên loại vật liệu không được bỏ trống", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Category category = new Category(maloaivl, tenloaivl);
                    categoryBUS.updateCategory(category);
                    loadData();
                    ResetData();
                    MessageBox.Show("Cập nhật Loại Vật Liệu Thành Công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               


            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_loaiVL.AutoGenerateColumns = false;
            string name = txt_search.Text;
            List<Category> list = categoryBUS.searchCategories(name);
            if (list != null && list.Count > 0)
            {
                dgv_loaiVL.Columns["maloaivl"].DataPropertyName = "IdCategory";
                dgv_loaiVL.Columns["tenloaivl"].DataPropertyName = "NameCategory";
                dgv_loaiVL.DataSource= list;
            }
        }

        private void dgv_loaiVL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class formHome : Form
    {
        DateTime date = DateTime.Now;
        HomeBus homebus = new HomeBus();
        ProductBUS productbus = new ProductBUS();
       // private string nameE;

        public formHome()
        {
           //  nameE = name;
            InitializeComponent();
        }
        private void loadData()
        {
            this.lOAIVATLIEUTableAdapter.Fill(this.qLVATLIEUDataSet.LOAIVATLIEU);
            List<Product> products = productbus.getListProduct();
            dgv_VL.Columns["maVL"].DataPropertyName = "IdProduct";
            dgv_VL.Columns["tenVL"].DataPropertyName = "NameProduct";
            dgv_VL.Columns["dongia"].DataPropertyName = "PriceProduct";
            dgv_VL.Columns["donViTinh"].DataPropertyName = "DonViTinh";
            dgv_VL.Columns["soluong"].DataPropertyName = "Quantity";
            dgv_VL.Columns["loaiVL"].DataPropertyName = "IdCategory";
            dgv_VL.DataSource = products;

        }

        private void trang_chinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVATLIEU1DataSet.LOAIVATLIEU' table. You can move, or remove it, as needed.
            this.lOAIVATLIEUTableAdapter1.Fill(this.qLVATLIEU1DataSet.LOAIVATLIEU);
            // TODO: This line of code loads data into the 'qLVATLIEUDataSet.LOAIVATLIEU' table. You can move, or remove it, as needed.
            this.lOAIVATLIEUTableAdapter.Fill(this.qLVATLIEUDataSet.LOAIVATLIEU);
            lb_xinchao.Text = "Xin Chào " + Properties.Settings.Default.TENNV +"!";
            lb_date.Text = "Hôm này là ngày " + date.Day.ToString() + " tháng " + date.Month.ToString() + " năm " + date.Year.ToString();
            loadData();
        }

      

        private void LoaiVatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategory the_Loai = new formCategory();
            if (the_Loai != null)
            {
                the_Loai.Show();
            }

        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCustomer khach_Hang = new formCustomer();
            khach_Hang.Show();

        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*formAddInvoice hoa_Don = new formAddInvoice();
            hoa_Don.Show();*/
        }

        private void ThongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReport thong_Ke = new formReport();
            thong_Ke.Show();

        }

        private void dgv_VL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            if (row_index >= 0 && row_index < dgv_VL.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_VL.Rows[row_index];
                string id = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                if (int.TryParse(selectedRow.Cells[3].Value.ToString(), out int soluong))
                {
                    formStockReceive nhapVL = new formStockReceive(id, name, soluong);
                    nhapVL.ShowDialog();
                    loadData();
                   
                }
                else
                {
                    MessageBox.Show("Invalid numeric value in the selected cell.");
                }

            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOAIVATLIEUTableAdapter.FillBy(this.qLVATLIEUDataSet.LOAIVATLIEU);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maLoaiVL = cbx_maVL.SelectedValue.ToString();
            List<Product> products = productbus.FillterProductByIdLoaiVL(maLoaiVL);
            if (products != null && products.Count > 0) {
                dgv_VL.AutoGenerateColumns = false;

                dgv_VL.Columns["maVL"].DataPropertyName = "IdProduct";
                dgv_VL.Columns["tenVL"].DataPropertyName = "NameProduct";
                dgv_VL.Columns["dongia"].DataPropertyName = "PriceProduct";
                dgv_VL.Columns["donViTinh"].DataPropertyName = "DonViTinh";
                dgv_VL.Columns["soluong"].DataPropertyName = "Quantity";
                dgv_VL.Columns["loaiVL"].DataPropertyName = "IdCategory";
                dgv_VL.DataSource = products;

            }
            else
            {
                MessageBox.Show("không có sản phẩm nào" +maLoaiVL);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOAIVATLIEUTableAdapter.FillBy1(this.qLVATLIEUDataSet.LOAIVATLIEU);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txt_tenVL_TextChanged(object sender, EventArgs e)
        {
            string tenVL = txt_tenVL.Text;
            if(tenVL == "")
            {
                loadData();
            }
            else
            {
                List<Product> products = productbus.SearchByNameVL(tenVL);
                if (products != null && products.Count > 0)
                {
                    dgv_VL.AutoGenerateColumns = false;

                    dgv_VL.Columns["maVL"].DataPropertyName = "IdProduct";
                    dgv_VL.Columns["tenVL"].DataPropertyName = "NameProduct";
                    dgv_VL.Columns["dongia"].DataPropertyName = "PriceProduct";
                    dgv_VL.Columns["donViTinh"].DataPropertyName = "DonViTinh";
                    dgv_VL.Columns["soluong"].DataPropertyName = "Quantity";
                    dgv_VL.Columns["loaiVL"].DataPropertyName = "IdCategory";
                    dgv_VL.DataSource = products;

                }

            }
            
           

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            loadData();
            cbx_maVL.SelectedIndex = 0;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            FormAddProduct addProduct = new FormAddProduct();
            addProduct.Show();
        }

        private void cbx_maVL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class formCustomer : Form
    {
        CustomerBUS customerBUS = new CustomerBUS();

        public formCustomer()
        {
            InitializeComponent();
        }

        private void ResetData()
        {
            txt_dckh.Text = "";
            txt_makh.Text = "";
            txt_sdtkh.Text = "";
            txt_tenkh.Text = "";
        }
      
       
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string ten = txt_tenkh.Text;
            string sdtS = txt_sdtkh.Text;
           
            string dc = txt_dckh.Text;
            if (ten == "" && sdtS == "" && dc == "")
            {
                MessageBox.Show("Bạn chưa Nhập đầy đủ thông tin", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Customer customer = new Customer(0, ten, sdtS, dc);
                
                bool check = customerBUS.CheckExistCustomerByPhone(sdtS);
                if(check == false)
                {
                    customerBUS.InsertCustomer(customer);
                    ResetData();
                    LoadCutomer();
                    MessageBox.Show("Thêm Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Số Điện Thoại Đã Tồn Tại");
                }
               

            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string idS = txt_makh.Text;
            int id = Convert.ToInt32(idS);
            string ten = txt_tenkh.Text;
            string dc = txt_dckh.Text;
            string sdtS = txt_sdtkh.Text;
           
            if(idS == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để cập nhật", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if(ten == "" && dc == "" && sdtS == "")
                {
                    MessageBox.Show("Tất cả nội dung cập nhật không được để trống", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            Customer customer = new Customer(id, ten, sdtS, dc);
            customerBUS.UpdateCustomer(customer);
            ResetData();
            LoadCutomer();
            MessageBox.Show("Cập nhật Khách Hàng Thành Công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*if(customerBUS.CheckExistCustomerByPhone(sdt) == false)
            {
                customerBUS.UpdateCustomer(customer);
                ResetData();
                LoadCutomer();
                MessageBox.Show("Cập nhật Khách Hàng Thành Công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số Điện Thoại Đã Tồn Tại");
            }
           */


        }
        private void LoadCutomer()
        {
            List<Customer> list = customerBUS.getListCustomer();
            if(list != null && list.Count > 0)
            {
                dgv_customer.Columns["makh"].DataPropertyName = "IDCustomer";
                dgv_customer.Columns["tenkh"].DataPropertyName = "NameCustomer";
                dgv_customer.Columns["sdt"].DataPropertyName = "PhoneCustomer";
                dgv_customer.Columns["diachi"].DataPropertyName = "AddressCustomer";
                dgv_customer.DataSource = list;
            }

        }
        private void dgv_customer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0 && rowIndex < dgv_customer.Rows.Count)
            {
               
                DataGridViewRow selectedRow = dgv_customer.Rows[rowIndex];
                 txt_makh.Text = selectedRow.Cells[0].Value.ToString();
                 txt_tenkh.Text = selectedRow.Cells[1].Value.ToString();
                txt_sdtkh.Text = selectedRow.Cells[2].Value.ToString();
                txt_dckh.Text = selectedRow.Cells[3].Value.ToString();
                btn_AddInvoice.Enabled = true;
                btn_ViewInvoice.Enabled = true;
            }
            btn_Add.Enabled = false;
        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            LoadCutomer();
            btn_AddInvoice.Enabled = false;
            btn_ViewInvoice.Enabled = false;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string idS = txt_makh.Text;
            if(idS == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để xoá", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            int id = Convert.ToInt32(idS);
            customerBUS.DeleteCustomer(id);
            ResetData();
            LoadCutomer();
            MessageBox.Show("Xoá Thành Công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            LoadCutomer();

        }

        private void btn_AddInvoice_Click(object sender, EventArgs e)
        {
            string idS = txt_makh.Text;
            int id = Convert.ToInt32(idS);
            string name = txt_tenkh.Text;
            formAddInvoice addInvoice = new formAddInvoice(id, name);
            addInvoice.ShowDialog();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string sdtS = txt_search.Text;
            if(sdtS == "")
            {
                LoadCutomer();
            }
            else
            {
               
                
                List<Customer> list = customerBUS.SearchCustomer(sdtS);
                if (list != null && list.Count > 0)
                {
                    dgv_customer.Columns["makh"].DataPropertyName = "IDCustomer";
                    dgv_customer.Columns["tenkh"].DataPropertyName = "NameCustomer";
                    dgv_customer.Columns["sdt"].DataPropertyName = "PhoneCustomer";
                    dgv_customer.Columns["diachi"].DataPropertyName = "AddressCustomer";
                    dgv_customer.DataSource = list;

                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Khách Hàng");
                }

            }
           
        }

        private void btn_ViewInvoice_Click(object sender, EventArgs e)
        {
            string makhS = txt_makh.Text;
            int maKH = Convert.ToInt32(makhS);
            string tenKH = txt_tenkh.Text;
            string diachi = txt_dckh.Text;
            string sdtS = txt_sdtkh.Text;
           

            formViewInvoice viewInvoice = new formViewInvoice(maKH,tenKH, sdtS, diachi);
            viewInvoice.ShowDialog();
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

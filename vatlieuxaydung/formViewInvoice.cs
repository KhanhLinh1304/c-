using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace vatlieuxaydung
{
    public partial class formViewInvoice : Form
    {
        int makhachhang;
        string tenkhachhang;
        string sdtkhachhang;
        string dckhachhang;
        string mahoadonSelected;
        IvoiceBUS invoiceBUS = new IvoiceBUS();
        public formViewInvoice(int maKH, string tenKH, string sdtKH, string diachi)
        {
            InitializeComponent();
            this.makhachhang = maKH;
            this.tenkhachhang = tenKH;
            this.sdtkhachhang = sdtKH;
            this.dckhachhang = diachi;
        }


        private void dgv_mahoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            if(selected >= 0 && selected < dgv_mahoadon.Rows.Count)
            {

                DataGridViewRow selectedRow = dgv_mahoadon.Rows[selected];
                 mahoadonSelected = selectedRow.Cells[0].Value.ToString();
                 
                 // lb_tennv.Text = selectedRow.Cells[3].Value.ToString();
               // lb_tongtien.Text = selectedRow.Cells[2].Value.ToString();
            }
            List<MyItem> items = invoiceBUS.GetItemByIdInvoice(mahoadonSelected);
            if(items != null && items.Count > 0)
            {
                dgv_chitietHD.AutoGenerateColumns = false;
                dgv_chitietHD.Columns["maVL"].DataPropertyName = "IdItem";
                dgv_chitietHD.Columns["tenVL"].DataPropertyName = "TenVatLieu";
                dgv_chitietHD.Columns["soluong"].DataPropertyName = "QuantityItem";
                dgv_chitietHD.Columns["thanhtien"].DataPropertyName = "PriceItem";
                dgv_chitietHD.Columns["donvitinh"].DataPropertyName = "DonViTinh";

                dgv_chitietHD.DataSource = items;
            }
            
        }

        private void formViewInvoice_Load(object sender, EventArgs e)
        {
            lb_tenKH.Text = "Khách Hàng: " + tenkhachhang;
            lb_sdt.Text =   "Số Điện Thoại: " + sdtkhachhang;
            lb_diachi.Text = "Địa chỉ: " + dckhachhang;
           List<Invoice> ivoices =  invoiceBUS.GetInvoiceByIdUser(makhachhang);
            
            if (ivoices != null && ivoices.Count > 0) {
                dgv_mahoadon.AutoGenerateColumns = false;
                dgv_mahoadon.Columns["mahd"].DataPropertyName = "IdInvoice";
                dgv_mahoadon.Columns["total"].DataPropertyName = "TotalPrice";
                dgv_mahoadon.Columns["tenNV"].DataPropertyName = "EmployeeName";    
                dgv_mahoadon.DataSource = ivoices;

              }
                
                       
        }
    }
}

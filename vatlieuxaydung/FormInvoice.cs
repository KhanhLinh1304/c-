using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vatlieuxaydung
{
    public partial class FormInvoice : Form
    {
        string maHD;
        int totalInvoice;
        DateTime dateTime;
        int idKhachHang;
        IvoiceBUS invoiceBUS = new IvoiceBUS();
        HomeBus homeBUS = new HomeBus();
        public FormInvoice(string mahoadon,int idkh,int tongtien,DateTime date)
        {
            InitializeComponent();
           this.maHD = mahoadon;
           this.dateTime = date;
           this.totalInvoice = tongtien;
           this.idKhachHang = idkh;
        }
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                lb_tenNV.Text = "Nhân Viên Bán Hàng: " + Properties.Settings.Default.TENNV;
                lb_maDH.Text = "Mã Hoá Đơn: " + maHD;
                lb_tongtien.Text = "Tổng Tiền: " + totalInvoice;
                lB_time.Text = "Thời Gian: " + dateTime.ToString();
                Customer customer = invoiceBUS.GetCustomer(idKhachHang);
                lb_diachiKH.Text = "Địa Chỉ: " + customer.AddressCustomer.ToString();
                lb_tenKH.Text = "Khách Hàng:" + customer.NameCustomer.ToString();
                lB_sdtKH.Text = "Số Điện Thoại: " + customer.PhoneCustomer.ToString();
                List<MyItem> items = homeBUS.GetObject(maHD);
                listView.Items.Clear();
                if (items != null && items.Count > 0)
                {
                    // If columns are not initialized, add them
                    if (listView.Columns.Count == 0)
                    {
                        // Add columns
                        listView.Columns.Add("Tên Vật Liệu", 150);
                        listView.Columns.Add("Đơn Vị Tính", 100);
                        listView.Columns.Add("Số Lượng", 80);
                        listView.Columns.Add("Đơn Giá", 80);
                        listView.Columns.Add("Thành Tiền", 100);
                    }

                

                    // Add new items
                    foreach (MyItem item in items)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.TenVatLieu);
                        listViewItem.SubItems.Add(item.DonViTinh);
                        listViewItem.SubItems.Add(item.QuantityItem.ToString());
                        listViewItem.SubItems.Add(item.DonGia.ToString());
                        listViewItem.SubItems.Add(item.PriceItem.ToString());

                        listView.Items.Add(listViewItem);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

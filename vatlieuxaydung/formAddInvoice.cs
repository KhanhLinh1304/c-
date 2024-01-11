using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace vatlieuxaydung
{
   
    public partial class formAddInvoice : Form
    {
        ProductBUS productBus = new ProductBUS();
        IvoiceBUS ivoiceBUS = new IvoiceBUS();
        string idProduct;
        Common commnon = new Common();
        int idC;
        string nameC;

        string donvitinh;
        string soluong;
        int total = 0;
        int thanhtien = 0;
        public formAddInvoice(int id, string name)
        {
            InitializeComponent();
            this.idC = id;
            this.nameC = name;
        }

       public void ResetData()
        {
            txt_tenvl.Text = "";
            txt_price.Text = "";
            num_sl.Value = 0;
        }

        private void formAddInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVATLIEUDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            //  this.kHACHHANGTableAdapter.Fill(this.qLVATLIEUDataSet1.KHACHHANG);
            txt_maHoaDon.Text = commnon.randomText();
            txt_tenkh.Text = nameC;
            createDatePicker.Format = DateTimePickerFormat.Custom;
            createDatePicker.CustomFormat = "dd-MM-yyyy";
            txt_tenNV.Text = Properties.Settings.Default.TENNV;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHACHHANGTableAdapter.FillBy(this.qLVATLIEUDataSet1.KHACHHANG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if(txt_tenvl.Text == "" || num_sl.Value < 1)
            {
                if (txt_tenvl.Text == "")
                {
                    MessageBox.Show("Chưa có vật liệu nào được chọn", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (num_sl.Value < 1)
                {
                    MessageBox.Show("số lượng vật liệu phải lớn hơn 0", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                int soluongConvert = Convert.ToInt32(soluong);
                
                if(num_sl.Value < soluongConvert)
                {
                    bool isAlredyAdd = false;
                    foreach (ListViewItem item in listItems.Items)
                    {
                        if (item.SubItems[0].Text == dgv_vl.Rows[dgv_vl.CurrentRow.Index].Cells[0].Value.ToString())
                        {
                            isAlredyAdd = true;
                            break;
                        }
                        else
                        {
                            isAlredyAdd = false;
                        }
                    }
                    if (isAlredyAdd == true)
                    {
                        MessageBox.Show("Vật Liệu này đã có trong danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                         
                        int price = Convert.ToInt32(txt_price.Text);
                        thanhtien = Convert.ToInt32(num_sl.Value) * price;
                        total += thanhtien;
                        txt_tongtien.Text = total.ToString();
                        ListViewItem newRow = new ListViewItem(idProduct);
                       
                        newRow.SubItems.Add(txt_tenvl.Text);
                        newRow.SubItems.Add(donvitinh);
                        newRow.SubItems.Add(num_sl.Value.ToString());
                        newRow.SubItems.Add(price.ToString());
                        newRow.SubItems.Add(thanhtien.ToString());
                        listItems.Items.Add(newRow);
                        ResetData();
                      
                    }
                }
                else
                {
                    MessageBox.Show("số lượng vật liệu đang lớn hơn số lượng vật liệu hiện có", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
           
        }

        private void dgv_vl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_vl.Rows[dgv_vl.CurrentRow.Index].Cells[0].Value.ToString() != String.Empty && dgv_vl.Rows[dgv_vl.CurrentRow.Index].Cells[1].Value.ToString() != String.Empty)
            {
                txt_tenvl.Text = dgv_vl.Rows[dgv_vl.CurrentRow.Index].Cells[1].Value.ToString();
                idProduct = dgv_vl.Rows[dgv_vl.CurrentRow.Index].Cells[0].Value.ToString();
                int id = Convert.ToInt32(idProduct);
                Product product = productBus.getProductById(id);
                if (product != null)
                {
                    
                    txt_price.Text = product.PriceProduct.ToString();
                    donvitinh = product.DonViTinh.ToString();
                    soluong = product.Quantity.ToString();
                }
            }
        }

        private void txt_tenvl_TextChanged(object sender, EventArgs e)
        {

            List<Product> products = productBus.FindNameInInvoice(txt_tenvl.Text);
            if(products != null && products.Count > 0)
            {
                dgv_vl.AutoGenerateColumns = false;
                dgv_vl.Columns["mavl"].DataPropertyName = "IdProduct";
                dgv_vl.Columns["tenvatlieu"].DataPropertyName = "NameProduct";


                dgv_vl.DataSource = products;
            }
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listItems.SelectedItems.Count > 0)
            {
                
                   
                    txt_tenvl.Text = listItems.SelectedItems[0].SubItems[1].Text;
                    if (int.TryParse(listItems.SelectedItems[0].SubItems[3].Text, out int numericValue))
                    {
                        num_sl.Value = numericValue;
                    }
                    txt_price.Text = listItems.SelectedItems[0].SubItems[4].Text;

                
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    int money = int.Parse(listItems.SelectedItems[0].SubItems[5].Text); 
                    listItems.SelectedItems[0].Remove();
                    total -= money;
                    
                    txt_tongtien.Text = total.ToString();
                    txt_tenvl.Clear();
                    num_sl.Value = 0;
                    txt_price.Clear();
                }
            }

            }

        private void btn_InsertInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string mahdS = txt_maHoaDon.Text;
                int idKH = idC;
                int idNV = Properties.Settings.Default.MANV;
                DateTime aDateTime = DateTime.Now;
                string tongtienS = txt_tongtien.Text;
                int tongtien = Convert.ToInt32(tongtienS);
                List<MyItem> items = new List<MyItem>();
                foreach (ListViewItem item in listItems.Items)
                {
                    
                     MyItem myItem = new MyItem( "","",0,int.Parse(item.SubItems[0].Text),   
                                                         int.Parse(item.SubItems[3].Text),
                                                         int.Parse(item.SubItems[5].Text));



                      items.Add(myItem);

                }
                Invoice invoice = new Invoice(mahdS, idKH, tongtien, aDateTime, idNV);
                ivoiceBUS.CreateInvoices(invoice, items);
                FormInvoice invoiceView = new FormInvoice(mahdS, idKH, tongtien, aDateTime);
                invoiceView.Show();
                this.Hide();
               // MessageBox.Show("Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            

        }
    }
}

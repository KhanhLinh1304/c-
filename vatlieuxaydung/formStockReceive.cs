using BUS;
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
    public partial class formStockReceive : Form
    {
        ProductBUS productBUS = new ProductBUS();
        private int soluongR;
        
        public formStockReceive(string id, string name,int soluong)
        {
            InitializeComponent();
            txt_maVL.Text = id;
            txt_tenVL.Text = name;
            soluongR = soluong;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            
            try
            {
                int mavl = int.Parse(txt_maVL.Text);
                string sol = txt_soluong.Text;
                if(sol == "")
                {
                    MessageBox.Show("Bạn chưa Nhập số lượng hàng", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int sl = int.Parse(sol);
                    int soluong = soluongR + sl;
                    productBUS.UpdateQuantityProduct(soluong, mavl);
                    DialogResult dialog = MessageBox.Show("Nhập Số Lượng Hàng Thành Công", "Success", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                

            }
            catch(Exception ex)
            {
               
               MessageBox.Show("Nhập Hàng không Thành Công"+ex.Message);
            }
          

        }
    }
}

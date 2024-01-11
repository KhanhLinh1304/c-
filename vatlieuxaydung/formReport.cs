using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vatlieuxaydung
{
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
           
        }
        int totalTongTien;
        ReportBUS reportBUS = new ReportBUS();
        private void iconButton1_Click(object sender, EventArgs e)
        {
          //  string format = "yyyy-MM-dd HH:mm:ss";
            string startDateS = startDate.Value.ToString("yyyy-MM-dd");
            string startTime= "00:00:00";
            string toDateS = toDate.Value.ToString("yyyy-MM-dd");
            string toTime= "23:59:59";
            string fromDateTime = startDateS + " "+ startTime;
            string toDateTime = toDateS + " "+ toTime;


            List<MyItem> items = reportBUS.GetMyItems(fromDateTime, toDateTime);
            if(items != null && items.Count > 0)
            {
               
                dgv_report.AutoGenerateColumns = false;
                dgv_report.Columns["maVL"].DataPropertyName = "IdItem";
                dgv_report.Columns["tenVL"].DataPropertyName = "TenVatLieu";
                dgv_report.Columns["soluong"].DataPropertyName = "QuantityItem";
                dgv_report.Columns["tongtien"].DataPropertyName = "PriceItem";
                dgv_report.DataSource = items;
                 totalTongTien = items.Sum(item => item.PriceItem);
                
            }
            lb_tongtien.Text = "Tổng Tiền "+totalTongTien.ToString();

           // MessageBox.Show(date.ToString());
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using DTO;
using BUS;

namespace vatlieuxaydung
{
    public partial class FormAddProduct : Form
    {
        ProductBUS productBus = new ProductBUS();
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void InsertData()
        {
            try
            {
             //   productBus.SetIdentityInsert(true);
                for (int row = 0; row < dgv_vatlieu.RowCount ; row++)
                {
                    int quantity = int.Parse(dgv_vatlieu.Rows[row].Cells[2].Value.ToString());
                    int dongia = int.Parse(dgv_vatlieu.Rows[row].Cells[1].Value.ToString());
                    string donvitinh = dgv_vatlieu.Rows[row].Cells[4].Value.ToString();
                    if (dgv_vatlieu.Rows[row].Cells[0].Value.ToString() != null && dgv_vatlieu.Rows[row].Cells[1].Value.ToString() != null && dgv_vatlieu.Rows[row].Cells[2].Value.ToString() != null && dgv_vatlieu.Rows[row].Cells[3].Value.ToString() != null && dgv_vatlieu.Rows[row].Cells[4].Value.ToString() != null)
                    {
                        Product product = new Product(0, dgv_vatlieu.Rows[row].Cells[0].Value.ToString(), dongia,  quantity, dgv_vatlieu.Rows[row].Cells[3].Value.ToString(),donvitinh);
                      
                        productBus.InsertProduct(product);
                    }
                    else
                    {
                        MessageBox.Show("Some cells are null in row " + (row + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
  
                MessageBox.Show("Thêm vật liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Refresh();
                this.Hide();

            }
            catch (Exception ex)
            {
               
          MessageBox.Show("Phát hiện lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_ReadExcel_Click(object sender, EventArgs e)
        {
            string fileName = "";
            OpenFileDialog fdlg = new OpenFileDialog();//mo hop thoai cho phep chon file
            fdlg.Title = "Excel File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileName = fdlg.FileName;
            }
            if (fileName != String.Empty)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                // dt.Column = colCount;  
                dgv_vatlieu.ColumnCount = colCount;
                dgv_vatlieu.RowCount = rowCount;

                for (int i = 2; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            dgv_vatlieu.Rows[i - 2].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                        }
                        else
                        {
                            dgv_vatlieu.Rows[i - 2].Cells[j - 1].Value = string.Empty;

                        }
                    }
                } 
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
        }

        private void btn_SaveDB_Click(object sender, EventArgs e)
        {
            if(dgv_vatlieu.Rows.Count > 1)
            {
                InsertData();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

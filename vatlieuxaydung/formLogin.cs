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
using System.Windows.Markup;

namespace vatlieuxaydung
{
    public partial class formLogin : Form
    {
        EmployeeBUS employeeBUS = new EmployeeBUS();
        public formLogin()
        {
            InitializeComponent();
        }
        public void ResetValue()
        {
            txt_email.Text = "";
            txt_pass.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
            string email = txt_email.Text;
            string pass = txt_pass.Text;
            if(email == "")
            {
                MessageBox.Show("Bạn chưa Nhập email", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(pass == "")
            {
                MessageBox.Show("Bạn chưa Nhập mật khẩu", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                Employee employee = employeeBUS.GetEmployeeByEmail(email, pass);
                //string name = employee.NameEmployee;
                //int id = employee.IdEmployee;
               /* if(name == null && id == null)
                {
                    MessageBox.Show("email hoặc password sai", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                if (employee != null)
                {
                    ResetValue();
                    Properties.Settings.Default.EMAIL = employee.Email.ToString();
                    Properties.Settings.Default.TENNV = employee.NameEmployee;
                    Properties.Settings.Default.MANV = employee.IdEmployee;
                    Properties.Settings.Default.Save();
                    this.Hide();

                    formHome trangchinh = new formHome();
                    trangchinh.Show();
                    MessageBox.Show("Đăng Nhập Thành Công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("email hoặc password sai", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using Project_PRN211_Group3.DAL;
using Project_PRN211_Group3.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN211_Group3.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> list = UserDAO.GetInstance().GetList();
            User user = list.Where(m => m.UserName == txtUserName.Text
                && m.Password == txtPassword.Text)
                .FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                Settings.UserName = user.UserName;
                Settings.UserID = user.CusId;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Người dùng không tồn tại");
                Settings.UserName = "";
                Settings.UserID = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

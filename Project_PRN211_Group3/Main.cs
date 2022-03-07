using Project_PRN211_Group3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN211_Group3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            if (mi.Text == "Đăng nhập")
            {
                Login f = new Login();
                f.ShowDialog();
            }
            else
            {
                Settings.UserName = "";
                Settings.UserID = -1;
                
                MessageBox.Show("Đăng xuất");

            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (Settings.UserName != "")
            {
                loginToolStripMenuItem.Text = $"Đăng xuất ({Settings.UserName})";
               
            }
            else
            {
                loginToolStripMenuItem.Text = "Đăng nhập";
               
            }
        }
    }
}

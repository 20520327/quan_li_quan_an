using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát?","Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Dangnhap_Click(object sender, EventArgs e)
        {
            Maintable f = new Maintable();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Sign_up f = new Sign_up();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

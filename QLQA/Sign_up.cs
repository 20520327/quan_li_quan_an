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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn chưa chấp nhận điều khoản của ứng dụng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

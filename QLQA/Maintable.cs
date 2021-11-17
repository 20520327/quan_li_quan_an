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
    public partial class Maintable : Form
    {
        public Maintable()
        {
            InitializeComponent();
            Clock.Text = DateTime.Now.ToString();
        }



        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Maintable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin f = new admin();
            this.Hide();
            f.ShowDialog();
            this.Show();    
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accountinfo f = new Accountinfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLíMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Food f = new Food();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table f = new Table();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString();
        }
    }
}

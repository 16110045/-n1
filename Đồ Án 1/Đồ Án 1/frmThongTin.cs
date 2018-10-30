using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Đồ_Án_1
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tuyensinh.hcmute.edu.vn/#/home");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
             MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes) Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.facebook.com/vinh.levan.1293");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmM = new frmMain();
            frmM.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/dai.dg.1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/hoanghung0098");
        }

       
    }
}

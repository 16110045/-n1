using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            button10.Text = "Clock\n" + System.DateTime.Now.ToString();
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmtkb = new frmXepThoiKhoaBieu();
            frmtkb.ShowDialog();
            this.Close();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmmh = new frmMonHoc();
            frmmh.ShowDialog();
            this.Close();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmgv = new frmGiaoVien();
            frmgv.ShowDialog();
            this.Close();
        }

        private void btnNganh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmnganh = new frmNganh();
            frmnganh.ShowDialog();
            this.Close();
        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmbm = new frmBoMon();
            frmbm.ShowDialog();
            this.Close();
        }

        private void btnTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmtiet = new frmTiet();
            frmtiet.ShowDialog();
            this.Close();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmlop = new frmLop();
            frmlop.ShowDialog();
            this.Close();
        }

        private void btnPhongHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmphonghoc = new frmPhongHoc();
            frmphonghoc.ShowDialog();
            this.Close();
        }

        private void btnThongTIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmthongtin = new frmThongTin();
            frmthongtin.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tl =
                MessageBox.Show("Bạn có muốn thoát không??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes) Application.Exit();
        }
    }
}

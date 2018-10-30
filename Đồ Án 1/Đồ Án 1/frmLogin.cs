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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
        public bool KTDangNhap()
        {
            if (txtTaiKhoan.Text == "Admin" && txtMatKhau.Text == "123")
            {
                var taikhoan = (from tk in dbs.TaiKhoans
                                where tk.TenDangNhap == txtTaiKhoan.Text && tk.MatKhau.ToString() == txtMatKhau.Text
                                select tk).SingleOrDefault();

                return true;
            }
            else return false;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool kt = KTDangNhap();
            if (kt == true)
            {
                this.Hide();
                Form frmM = new frmMain();
                frmM.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu ");
            }
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

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(null, null);
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(null, null);
        }

       
    }
}

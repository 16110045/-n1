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
    public partial class frmNganh : Form
    {
        bool them = false;
        public frmNganh()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
            var query =
                from p in dbs.Nganhs
                select new
                {
                    p.MaNganh,
                    p.TenNganh
                };
            dgvNganh.DataSource = query;
            gpNganh.Enabled = false;
            txtMaNganh.ResetText();
            txtTenNganh.ResetText();
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNganh.CurrentCell.RowIndex;
            txtMaNganh.Text = dgvNganh.Rows[r].Cells[0].Value.ToString();
            txtTenNganh.Text = dgvNganh.Rows[r].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpNganh.Enabled = true;
            txtMaNganh.Enabled = true;
            txtMaNganh.ResetText();
            txtTenNganh.ResetText();
            txtMaNganh.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            gpNganh.Enabled = true;
            txtMaNganh.Enabled = false;
            txtTenNganh.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Chắc xóa không!!", "Lỗi rồi!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(trl==DialogResult.OK)
            {
                try
                {
                    XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                    var n1 = from p in dbs.Nganhs
                             where p.MaNganh.ToString() == txtMaNganh.Text
                             select p;
                    dbs.Nganhs.DeleteAllOnSubmit(n1);
                    dbs.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Đã xóa xong");
                }
                catch(Exception)
                {
                    MessageBox.Show("Không xóa được,Lỗi rồi!!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(!txtMaNganh.Text.Trim().Equals(""))
            {
                if(them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        Nganh nganh = new Nganh();
                        nganh.MaNganh = Convert.ToInt32(txtMaNganh.Text);
                        nganh.TenNganh = txtTenNganh.Text;
                        dbs.Nganhs.InsertOnSubmit(nganh);
                        dbs.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Đã thêm xong");
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Không thêm được,Lỗi rồi!!");
                    }
                }
                else
                {
                    try
                    {
                        int r = dgvNganh.CurrentCell.RowIndex;
                        string ma = dgvNganh.Rows[r].Cells[0].Value.ToString();
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        var ng = (from p in dbs.Nganhs
                                  where p.MaNganh.ToString() == ma
                                  select p).SingleOrDefault();
                        if(ng !=null)
                        {
                            ng.TenNganh = txtTenNganh.Text;
                            dbs.SubmitChanges();
                            LoadData();
                        }
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Không sửa được,Lỗi rồi!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ngành chưa có,Lỗi rồi!!");
                txtMaNganh.Focus();
            }
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
            MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes) Application.Exit();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmM = new frmMain();
            frmM.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
              MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes) Application.Exit();
        }
    }
}

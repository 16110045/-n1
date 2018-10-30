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
    public partial class frmBoMon : Form
    {
        bool them = false;
        public frmBoMon()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
            var query =
                from p in dbs.BoMons
                select new
                {
                    p.MaBM,
                    p.TenBM
                };
            dgvBoMon.DataSource = query;
            gpBoMon.Enabled = false;
            txtMaBM.ResetText();
            txtTenBM.ResetText();
        }
        private void frmBoMon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvBoMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBoMon.CurrentCell.RowIndex;
            txtMaBM.Text = dgvBoMon.Rows[r].Cells[0].Value.ToString();
            txtTenBM.Text = dgvBoMon.Rows[r].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpBoMon.Enabled = true;
            txtMaBM.Enabled = true;
            txtMaBM.ResetText();
            txtTenBM.ResetText();
            txtMaBM.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            gpBoMon.Enabled = true;
            txtMaBM.Enabled = false;
            txtTenBM.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult trl;
            trl = MessageBox.Show("Chắc xóa không!!", "Lỗi rồi!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trl == DialogResult.OK)
            {
                try
                {
                    XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                    var n1 = from p in dbs.BoMons
                             where p.MaBM.ToString() == txtMaBM.Text
                             select p;
                    dbs.BoMons.DeleteAllOnSubmit(n1);
                    dbs.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Đã xóa xong");
                }
                catch (Exception)
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
            if (!txtMaBM.Text.Trim().Equals(""))
            {
                if (them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        BoMon bm = new BoMon();
                        bm.MaBM = Convert.ToInt32(txtMaBM.Text);
                        bm.TenBM = txtTenBM.Text;
                        dbs.BoMons.InsertOnSubmit(bm);
                        dbs.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Đã thêm xong");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thêm được,Lỗi rồi!!");
                    }
                }
                else
                {
                    try
                    {
                        int r = dgvBoMon.CurrentCell.RowIndex;
                        string ma = dgvBoMon.Rows[r].Cells[0].Value.ToString();
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        var ng = (from p in dbs.BoMons
                                  where p.MaBM.ToString() == ma
                                  select p).SingleOrDefault();
                        if (ng != null)
                        {
                            ng.TenBM = txtTenBM.Text;
                            dbs.SubmitChanges();
                            LoadData();
                        }
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không sửa được,Lỗi rồi!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bộ Môn chưa có,Lỗi rồi!!");
                txtMaBM.Focus();
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

    }
}

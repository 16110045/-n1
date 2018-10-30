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
    public partial class frmPhongHoc : Form
    {
        bool them = false;
        public frmPhongHoc()
        {
            InitializeComponent();
        }

        private void frmPhongHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
            var query =
                from p in dbs.PhongHocs
                select new
                {
                    p.MaPH,
                    p.TenPH,
                    p.DungLuong
                };
            dgvPhongHoc.DataSource = query;
            gpPhongHoc.Enabled = false;
            txtMaPH.ResetText();
            txtTenPH.ResetText();
            txtDungLuong.ResetText();
        }

        private void dgvPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhongHoc.CurrentCell.RowIndex;
            txtMaPH.Text = dgvPhongHoc.Rows[r].Cells[0].Value.ToString();
            txtTenPH.Text = dgvPhongHoc.Rows[r].Cells[1].Value.ToString();
            txtDungLuong.Text = dgvPhongHoc.Rows[r].Cells[2].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataKeyWord();
        }
        public void LoadDataKeyWord()
        {
            try
            {
                XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                var query =
                    from p in dbs.PhongHocs
                    select new
                    {
                        p.MaPH,
                        p.TenPH,
                        p.DungLuong
                    };
                dgvPhongHoc.DataSource = query.Where(p => p.MaPH.ToString().Contains(txtSearch.Text) || p.TenPH.Contains(txtSearch.Text) ||
                p.DungLuong.ToString().Contains(txtSearch.Text));

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi rồi!!!");
            }
            gpPhongHoc.Enabled = false;
            txtMaPH.ResetText();
            txtTenPH.ResetText();
            txtDungLuong.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpPhongHoc.Enabled = true;
            txtMaPH.Enabled = true;
            txtMaPH.ResetText();
            txtTenPH.ResetText();
            txtDungLuong.ResetText();
            txtMaPH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvPhongHoc_CellClick(null, null);
            gpPhongHoc.Enabled = true;
            txtMaPH.Enabled = false;
            txtTenPH.Focus();
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
                    var n1 = from p in dbs.PhongHocs
                             where p.MaPH.ToString() == txtMaPH.Text
                             select p;
                    dbs.PhongHocs.DeleteAllOnSubmit(n1);
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
            if (!txtMaPH.Text.Trim().Equals(""))
            {
                if (them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        PhongHoc gv = new PhongHoc();
                        gv.MaPH = Convert.ToInt32(txtMaPH.Text);
                        gv.TenPH = txtTenPH.Text;
                        gv.DungLuong = Convert.ToInt32(txtDungLuong.Text);
                        dbs.PhongHocs.InsertOnSubmit(gv);
                        dbs.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Đã thêm Xong");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thêm được!!", "lỗi rồi!");
                    }
                }
                else
                {
                    try
                    {
                        // Thứ tự dòng hiện hành
                        int r = dgvPhongHoc.CurrentCell.RowIndex;
                        // MaKH hiện hành
                        string Ma = dgvPhongHoc.Rows[r].Cells[0].Value.ToString();
                        // Câu lệnh SQL
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        var gv = (from gv1 in dbs.PhongHocs
                                  where gv1.MaPH.ToString() == Ma
                                  select gv1).SingleOrDefault();
                        if (gv != null)
                        {
                            gv.TenPH = txtTenPH.Text;
                            gv.DungLuong = Convert.ToInt32(txtDungLuong.Text);
                            dbs.SubmitChanges();
                            LoadData();
                        }
                        LoadData();
                        MessageBox.Show("Đã sửa xong");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không sửa được", "lỗi rồi!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Phòng chưa có.Lỗi rồi!!");
                txtMaPH.Focus();
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

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
    public partial class frmMonHoc : Form
    {
        bool them = false;
        public frmMonHoc()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
            var query =
                from p in dbs.MonHocs
                select new
                {
                    p.MaMH,
                    p.TenMH,
                    p.MaBM
                };
            dgvMonHoc.DataSource = query;
            gpMonHoc.Enabled = false;
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtMaBM.ResetText();
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpMonHoc.Enabled = true;
            txtMaMH.Enabled = true;
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtMaBM.ResetText();
            txtMaMH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvMonHoc_CellClick(null, null);
            gpMonHoc.Enabled = true;
            txtMaMH.Enabled = false;
            txtTenMH.Focus();
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
                    var n1 = from p in dbs.MonHocs
                             where p.MaMH.ToString() == txtMaMH.Text
                             select p;
                    dbs.MonHocs.DeleteAllOnSubmit(n1);
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
            if (!txtMaMH.Text.Trim().Equals(""))
            {
                if (them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        MonHoc gv = new MonHoc();
                        gv.MaMH = Convert.ToInt32(txtMaMH.Text);
                        gv.TenMH = txtTenMH.Text;
                        gv.MaBM = Convert.ToInt32(txtMaBM.Text);
                        dbs.MonHocs.InsertOnSubmit(gv);
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
                        int r = dgvMonHoc.CurrentCell.RowIndex;
                        // MaKH hiện hành
                        string Ma = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
                        // Câu lệnh SQL
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        var gv = (from gv1 in dbs.MonHocs
                                  where gv1.MaMH.ToString() == Ma
                                  select gv1).SingleOrDefault();
                        if (gv != null)
                        {
                            gv.TenMH = txtTenMH.Text;
                            gv.MaBM = Convert.ToInt32(txtMaBM.Text);
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
                txtMaMH.Focus();
            }
            LoadData();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMonHoc.CurrentCell.RowIndex;
            txtMaMH.Text = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[r].Cells[1].Value.ToString();
            txtMaBM.Text = dgvMonHoc.Rows[r].Cells[2].Value.ToString();
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
                    from p in dbs.MonHocs
                    select new
                    {
                        p.MaMH,
                        p.TenMH,
                        p.MaBM
                    };
                dgvMonHoc.DataSource = query.Where(p => p.MaMH.ToString().Contains(txtSearch.Text) || p.TenMH.Contains(txtSearch.Text) ||
                p.MaBM.ToString().Contains(txtSearch.Text));

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi rồi!!!");
            }
            gpMonHoc.Enabled = false;
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtMaBM.ResetText();
        }
    }
}

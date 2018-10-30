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
    public partial class frmLop : Form
    {
        bool them = false;
        public frmLop()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
            var query =
                from p in dbs.Lops
                select new
                {
                    p.MaLop,
                    p.TenLop,
                    p.SoSV,
                    p.MaNganh
                };
            dgvLop.DataSource = query.Skip(1);
            gpLop.Enabled = false;
            txtMaLop.ResetText();
            txtTenLop.ResetText();
            txtSoSV.ResetText();
            txtMaNganh.ResetText();
            txtMaLop.Enabled = true;
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLop.CurrentCell.RowIndex;
            txtMaLop.Text = dgvLop.Rows[r].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[r].Cells[1].Value.ToString();
            txtSoSV.Text = dgvLop.Rows[r].Cells[2].Value.ToString();
            txtMaNganh.Text = dgvLop.Rows[r].Cells[3].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpLop.Enabled = true;
            txtMaLop.Enabled = true;
            txtMaLop.ResetText();
            txtTenLop.ResetText();
            txtSoSV.ResetText();
            txtMaNganh.ResetText();
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvLop_CellClick(null, null);
            gpLop.Enabled = true;
            txtMaLop.Enabled = false;
            txtTenLop.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                try
                {
                    XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                    var gv = from p in dbs.Lops
                             where p.MaLop.ToString() == txtMaLop.Text
                             select p;
                    dbs.Lops.DeleteAllOnSubmit(gv);
                    dbs.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Đã Xóa Xong");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được", "lỗi rồi!!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtMaLop.Text.Trim().Equals(""))
            {
                if (them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        Lop gv = new Lop();
                        gv.MaLop = Convert.ToInt32(txtMaLop.Text);
                        gv.TenLop = txtTenLop.Text;
                        gv.SoSV = Convert.ToInt32( txtSoSV.Text);
                        gv.MaNganh = Convert.ToInt32( txtMaNganh.Text);                       
                        dbs.Lops.InsertOnSubmit(gv);
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
                        int r = dgvLop.CurrentCell.RowIndex;
                        // MaKH hiện hành
                        string Ma = dgvLop.Rows[r].Cells[0].Value.ToString();
                        // Câu lệnh SQL
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        var gv = (from gv1 in dbs.Lops
                                  where gv1.MaLop.ToString() == Ma
                                  select gv1).SingleOrDefault();
                        if (gv != null)
                        {
                            gv.TenLop = txtTenLop.Text;
                            gv.SoSV =Convert.ToInt32( txtSoSV.Text);
                            gv.MaNganh = Convert.ToInt32( txtMaNganh.Text);
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
                MessageBox.Show("Lớp chưa có.Lỗi rồi!!");
                txtMaLop.Focus();
            }
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
             MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes) Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
             MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes) Application.Exit();
        }
        public void LoadDataKeyWord()
        {
            try
            {
                XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                var query =
                    from p in dbs.Lops
                    select new
                    {
                        p.MaLop,
                        p.TenLop,
                        p.SoSV,
                        p.MaNganh
                    };
                dgvLop.DataSource = query.Where(p => p.MaLop.ToString().Contains(txtSearch.Text) || p.TenLop.Contains(txtSearch.Text) ||
                p.SoSV.ToString().Contains(txtSearch.Text) || p.MaNganh.ToString().Contains(txtSearch.Text));
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi rồi!!!");
            }
            gpLop.Enabled = false;
            txtMaLop.ResetText();
            txtTenLop.ResetText();
            txtSoSV.ResetText();
            txtMaNganh.ResetText();
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
    }
}

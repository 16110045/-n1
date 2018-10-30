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
    public partial class frmTiet : Form
    {
        bool them = false;
        public frmTiet()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
            var query =
                from p in dbs.Tiets
                select new
                {
                    p.STT,
                    p.Tiet1,
                    p.Thu,
                    p.Time
                };
            dgvTiet.DataSource = query;
            gpTiet.Enabled = false;
            txtSTT.ResetText();
            txtTiet.ResetText();
            txtThu.ResetText();
            txtThoiGian.ResetText();
            txtSTT.Enabled = true;
        }
        private void frmTiet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTiet.CurrentCell.RowIndex;
            txtSTT.Text = dgvTiet.Rows[r].Cells[0].Value.ToString();
            txtTiet.Text = dgvTiet.Rows[r].Cells[1].Value.ToString();
            txtThu.Text = dgvTiet.Rows[r].Cells[2].Value.ToString();
            txtThoiGian.Text = dgvTiet.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpTiet.Enabled = true;
            txtSTT.Enabled = true;
            txtSTT.ResetText();
            txtTiet.ResetText();
            txtThu.ResetText();
            txtThoiGian.ResetText();
            txtSTT.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvTiet_CellClick(null, null);
            gpTiet.Enabled = true;
            txtSTT.Enabled = false;
            txtTiet.Focus();
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
                    var gv = from p in dbs.Tiets
                             where p.STT.ToString() == txtSTT.Text
                             select p;
                    dbs.Tiets.DeleteAllOnSubmit(gv);
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
            if (!txtSTT.Text.Trim().Equals(""))
            {
                if (them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        Tiet gv = new Tiet();
                        gv.STT = Convert.ToInt32(txtSTT.Text);
                        gv.Tiet1 = Convert.ToInt32( txtTiet.Text);
                        gv.Thu = Convert.ToInt32(txtThu.Text);
                        gv.Time = txtThoiGian.Text;
                        dbs.Tiets.InsertOnSubmit(gv);
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
                        int r = dgvTiet.CurrentCell.RowIndex;
                        // MaKH hiện hành
                        string Ma = dgvTiet.Rows[r].Cells[0].Value.ToString();
                        // Câu lệnh SQL
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        var gv = (from gv1 in dbs.Tiets
                                  where gv1.STT.ToString() == Ma
                                  select gv1).SingleOrDefault();
                        if (gv != null)
                        {
                            gv.Tiet1 = Convert.ToInt32( txtTiet.Text);
                            gv.Thu = Convert.ToInt32(txtThu.Text);
                            gv.Time = txtThoiGian.Text;
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
                MessageBox.Show("Tiết chưa có.Lỗi rồi!!");
                txtSTT.Focus();
            }
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
                    from p in dbs.Tiets
                    select new
                    {
                        p.STT,
                        p.Tiet1,
                        p.Thu,
                        p.Time
                    };
                dgvTiet.DataSource = query.Where(p => p.STT.ToString().Contains(txtSearch.Text) || p.Tiet1.ToString().Contains(txtSearch.Text) ||
                p.Thu.ToString().Contains(txtSearch.Text) || p.Time.ToString().Contains(txtSearch.Text));
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi rồi!!!");
            }
            gpTiet.Enabled = false;
            txtSTT.ResetText();
            txtTiet.ResetText();
            txtThu.ResetText();
            txtThoiGian.ResetText();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataKeyWord();
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

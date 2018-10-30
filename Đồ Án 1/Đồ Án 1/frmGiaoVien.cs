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
    public partial class frmGiaoVien : Form
    {
        bool them = false;
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        #region move form
        bool ismousedown = false; // Kiểm tra xem con trỏ chuột đã mousedown chưa
        Point mousedownPosition = new Point();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = true;
            mousedownPosition.X = e.X;
            mousedownPosition.Y = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = false;
            Cursor cur = Cursors.Arrow;
            this.Cursor = cur;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == true)
            {
                Point newPoint = new Point();
                newPoint.X = this.Location.X + (e.X - mousedownPosition.X);
                newPoint.Y = this.Location.Y + (e.Y - mousedownPosition.Y);
                this.Location = newPoint;
            }
        }
        #endregion
        public void LoadData()
        {
            try
            {
                XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                var query =
                    from p in dbs.GiaoViens
                    select new
                    {
                        p.MaGV,
                        p.TenGV,
                        p.GioiTinh,
                        p.SDT,
                        p.ChucVu,
                        p.Email,
                        p.MaBM,
                        p.DiaChi,                      
                        p.NgaySinh,
                    };
                dgvGiaoVien.DataSource = query;
            }
            catch(Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong table GiaoVien. Lỗi rồi!!!");
            }
            gpGiaoVien.Enabled = false;
            txtMaGV.ResetText();
            txtTenGV.ResetText();
            txtSDT.ResetText();
            txtChucVu.ResetText();
            txtEmail.ResetText();
            txtMaBM.ResetText();
            txtDiaChi.ResetText();         
            rdNam.Checked = false;
            rdNu.Checked = false;
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gpGiaoVien.Enabled = true;
            txtMaGV.ResetText();
            txtTenGV.ResetText();
            txtSDT.ResetText();
            txtChucVu.ResetText();
            txtEmail.ResetText();
            txtMaBM.ResetText();
            txtDiaChi.ResetText();          
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtMaGV.Enabled = true;
            txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvGiaoVien_CellClick_1(null, null);
            gpGiaoVien.Enabled = true;
            txtMaGV.Enabled = false;
            txtTenGV.Focus();
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
                    var gv = from p in dbs.GiaoViens
                             where p.MaGV.ToString() == txtMaGV.Text
                             select p;
                    dbs.GiaoViens.DeleteAllOnSubmit(gv);
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
            if (!txtMaGV.Text.Trim().Equals(""))
            {
                if (them)
                {
                    try
                    {
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                        GiaoVien gv = new GiaoVien();
                        gv.MaGV = Convert.ToInt32(txtMaGV.Text);
                        gv.TenGV = txtTenGV.Text;
                        gv.SDT = txtSDT.Text;
                        gv.ChucVu = txtChucVu.Text;
                        gv.Email = txtEmail.Text;
                        gv.MaBM = Convert.ToInt32(txtMaBM.Text);
                        gv.DiaChi = txtDiaChi.Text;                                            
                        gv.NgaySinh = DateTimeNgaySinh.Value.ToString();
                        if (rdNam.Checked == true)
                            gv.GioiTinh = "Nam";
                        else
                            gv.GioiTinh = "Nữ";

                        dbs.GiaoViens.InsertOnSubmit(gv);
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
                        int r = dgvGiaoVien.CurrentCell.RowIndex;
                        // MaKH hiện hành
                        string Ma = dgvGiaoVien.Rows[r].Cells[0].Value.ToString();
                        // Câu lệnh SQL
                        XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();  
                        var gv = (from gv1 in dbs.GiaoViens
                                  where gv1.MaGV.ToString() == Ma
                                  select gv1).SingleOrDefault();
                        if (gv != null)
                        {
                            gv.TenGV = txtTenGV.Text;
                            gv.SDT = txtSDT.Text;
                            gv.ChucVu = txtChucVu.Text;
                            gv.Email = txtEmail.Text;
                            gv.MaBM = Convert.ToInt32(txtMaBM.Text);
                            gv.DiaChi = txtDiaChi.Text;                                                                                                     
                            if (rdNam.Checked == true)
                                gv.GioiTinh = "Nam";
                            else
                                gv.GioiTinh = "Nữ";
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
                MessageBox.Show("Giáo viên chưa có.Lỗi rồi!!");
                txtMaGV.Focus();
            }
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
              MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes) Application.Exit();
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
        public void LoadDataKeyWord()
        {
            try
            {
                XepThoiKhoaBieuDataContext dbs = new XepThoiKhoaBieuDataContext();
                var query =
                    from p in dbs.GiaoViens
                    select new
                    {
                        p.MaGV,
                        p.TenGV,
                        p.GioiTinh,
                        p.SDT,
                        p.ChucVu,
                        p.Email,
                        p.MaBM,
                        p.DiaChi,
                        p.NgaySinh                                             
                    };
                dgvGiaoVien.DataSource = query.Where(p => p.MaGV.ToString().Contains(txtSearch.Text) || p.TenGV.Contains(txtSearch.Text) ||
                p.SDT.Contains(txtSearch.Text) || p.ChucVu.Contains(txtSearch.Text) || p.Email.Contains(txtSearch.Text) || p.MaBM.ToString().Contains(txtSearch.Text)
                || p.DiaChi.Contains(txtSearch.Text) || p.GioiTinh.Contains(txtSearch.Text) || (p.NgaySinh.ToString()).Contains(txtSearch.Text));

                rdNam.Checked = false;
                rdNu.Checked = false;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi rồi!!!");
            }
            gpGiaoVien.Enabled = false;
            txtMaGV.ResetText();
            txtTenGV.ResetText();
            txtSDT.ResetText();
            txtChucVu.ResetText();
            txtEmail.ResetText();
            txtMaBM.ResetText();
            txtDiaChi.ResetText();          
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

        private void dgvGiaoVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGiaoVien.CurrentCell.RowIndex;
            txtMaGV.Text = dgvGiaoVien.Rows[r].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGiaoVien.Rows[r].Cells[1].Value.ToString();
            string gioitinh = dgvGiaoVien.Rows[r].Cells[2].Value.ToString();
            if (gioitinh == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtSDT.Text = dgvGiaoVien.Rows[r].Cells[3].Value.ToString();
            txtChucVu.Text = dgvGiaoVien.Rows[r].Cells[4].Value.ToString();
            txtEmail.Text = dgvGiaoVien.Rows[r].Cells[5].Value.ToString();
            txtMaBM.Text = dgvGiaoVien.Rows[r].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvGiaoVien.Rows[r].Cells[7].Value.ToString();
            DateTimeNgaySinh.Value = Convert.ToDateTime(dgvGiaoVien.Rows[r].Cells[8].Value.ToString());
        }
    }
}

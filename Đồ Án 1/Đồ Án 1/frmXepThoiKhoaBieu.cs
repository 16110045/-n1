using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Đồ_Án_1
{

    public partial class frmXepThoiKhoaBieu : Form
    {
    public List<Gv_MonHoc> GVMHTable = new List<Gv_MonHoc>();
    public List<Lop_Phong> LPTable = new List<Lop_Phong>();
    public List<Lop_MonHoc> Lop_Monhoc = new List<Lop_MonHoc>();
    public List<Gv_Lop> GiaoVien_LopHoc = new List<Gv_Lop>();
    public List<Lop_MonHoc_Tiet> Lop_T_MH = new List<Lop_MonHoc_Tiet>();
    public List<ThoiKhoaBieu> tkb = new List<ThoiKhoaBieu>();
    public int xet = 0;
    public int g = 0;
    public int m = 0;
    public int l = 0;
    public int p = 0;
    public List<GiaoVien> givi = new List<GiaoVien>();
    public List<MonHoc> moho = new List<MonHoc>();
    public List<Lop> loho = new List<Lop>();
    public List<PhongHoc> phho = new List<PhongHoc>();
    public List<Chon> chon;

    public void XThoiKhoaBieu()
    {
            try
            {
                XepThoiKhoaBieuDataContext xl = new XepThoiKhoaBieuDataContext();

                var giaovien =
                    from d in xl.GiaoViens
                    select d;
                var monhoc =
                    from d in xl.MonHocs
                    select d;
                var lop =
                    from d in xl.Lops
                    select d;
                var phong =
                    from d in xl.PhongHocs
                    select d;

                foreach (var gt in giaovien)
                {
                    GiaoVien gv = new GiaoVien(); // add thuộc tính trong list
                    gv.MaGV = gt.MaGV;
                    gv.TenGV = gt.TenGV;
                    gv.MaBM = gt.MaBM;
                    givi.Add(gv);
                    g++;
                }

                foreach (var gt in monhoc)
                {
                    MonHoc MH = new MonHoc();
                    MH.MaMH = gt.MaMH;
                    MH.TenMH = gt.TenMH;
                    MH.MaBM = gt.MaBM;
                    moho.Add(MH);
                    m++;
                }
                foreach (var gt in lop)
                {
                    Lop LOP = new Lop();
                    LOP.MaLop = gt.MaLop;
                    LOP.TenLop = gt.TenLop;
                    loho.Add(LOP);
                    l++;
                }

                foreach (var gt in phong)
                {
                    PhongHoc PH = new PhongHoc();
                    PH.MaPH = gt.MaPH;
                    PH.TenPH = gt.TenPH;
                    phho.Add(PH);
                    p++;
                }

                int dem;
                dem = 1;

                //Giáo viên nào dạy môn nào
                for (int i = 0; i < g; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int cv;
                        if (givi[i].MaBM == moho[j].MaBM) // giáo viên đó dạy môn học đó
                        {
                            Gv_MonHoc gvmh = new Gv_MonHoc();
                            gvmh.stt = dem;
                            gvmh.MaGV = givi[i].MaGV;
                            gvmh.MaMH = moho[j].MaMH;
                            cv = SoSanh(Int32.Parse(givi[i].MaGV.ToString()));
                            switch (cv)
                            {
                                case 0:
                                    {
                                        gvmh.SoTiet = 15; //
                                        break;
                                    }
                                case 1:
                                    {
                                        gvmh.SoTiet = 6; // Hiệu Trưởng
                                        break;
                                    }
                                case 2:
                                    {
                                        gvmh.SoTiet = 9; // Phó Hiệu Trưởng
                                        break;
                                    }
                                case 3:
                                    {
                                        gvmh.SoTiet = 11; // Trưởng Khoa
                                        break;
                                    }
                                case 4:
                                    {
                                        gvmh.SoTiet = 12; // Phó Trưởng Khoa
                                        break;
                                    }
                                case 5:
                                    {
                                        gvmh.SoTiet = 11; // Trưởng Phụ Trách
                                        break;
                                    }
                                case 6:
                                    {
                                        gvmh.SoTiet = 13; // Phó Phụ Trách
                                        break;
                                    }
                            }
                            GVMHTable.Add(gvmh);
                            dem++;
                        }
                    }
                }
                int ph = 0;
                //Lớp nào học phòng nào
                dem = 1;
                int check = 0;
                for (int i = 0; i < l; i++)
                {
                    if (Compare(loho[i].TenLop.ToString(), "1611") == true || (Compare(loho[i].TenLop.ToString(), "1613") == true
                        || (Compare(loho[i].TenLop.ToString(), "1645") == true)))
                    {
                        Lop_Phong lopphong = new Lop_Phong();
                        lopphong.stt = dem;
                        lopphong.MaLop = loho[i].MaLop;
                        lopphong.MaPH = phho[ph].MaPH;
                        lopphong.SoBuoi = "Sáng";
                        dem++;
                        LPTable.Add(lopphong);
                        check++;
                    }
                    else
                    {
                        Lop_Phong lopphong = new Lop_Phong();
                        lopphong.stt = dem;
                        lopphong.MaLop = loho[i].MaLop;
                        lopphong.MaPH = phho[ph].MaPH;
                        lopphong.SoBuoi = "Chiều";
                        dem++;
                        LPTable.Add(lopphong);
                        check++;
                    }
                    if (check >= 2)
                    {
                        ph++;
                        check = 0;
                    }
                }
                //Lớp nào học môn nào
                dem = 1;
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Lop_MonHoc lopmh = new Lop_MonHoc();
                        lopmh.stt = dem;
                        lopmh.MaLop = loho[i].MaLop;
                        lopmh.MaMH = moho[j].MaMH;
                        if (loho[i].MaLop <= 6) // 16110
                        {
                            if (lopmh.MaMH == 10) //Toán 1
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 1) //Anh văn 1
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 13 || lopmh.MaMH == 14 || lopmh.MaMH == 15 || lopmh.MaMH == 19
                                || lopmh.MaMH == 22 || lopmh.MaMH == 23)//vật lý 2,xác xuất và ứng dụng,đại số tuyến tính,gctc1,nhập môn lập trình,nhập môn ngành
                            {
                                lopmh.SoTiet = 3;
                            }
                            else if (lopmh.MaMH == 16 || lopmh.MaMH == 8 || lopmh.MaMH == 19) //gdqp1 ,maclenin,gdtc1
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else if (loho[i].MaLop > 6 && loho[i].MaLop <= 8) //16130
                        {
                            if (lopmh.MaMH == 10) //Toán 1
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 2) //Anh văn 2
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 7 || lopmh.MaMH == 6 || lopmh.MaMH == 24) // đường lối,tư tưởng hcm,thí nghiệm vật lý1
                            {
                                lopmh.SoTiet = 3;
                            }
                            else if (lopmh.MaMH == 17 || lopmh.MaMH == 20) //gcqp2,gdtc2
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else if (loho[i].MaLop > 8 && loho[i].MaLop <= 10) //16020
                        {
                            if (lopmh.MaMH == 11) //Toán 2
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 3) //Anh văn 3
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 7 || lopmh.MaMH == 25 || lopmh.MaMH == 24) // đường lối,vật lý 2,thí nghiệm vật lý1
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 18 || lopmh.MaMH == 21) //gcqp3,gdtc3
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else if (loho[i].MaLop > 10 && loho[i].MaLop <= 12) //16220
                        {
                            if (lopmh.MaMH == 12) //Toán 3
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 1) //Anh văn 1
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 9 || lopmh.MaMH == 15 || lopmh.MaMH == 23) // pldc,ds tuyến tính,nhập môn ngành
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 19 || lopmh.MaMH == 17) //gdtc1,gdqp2
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else if (loho[i].MaLop > 12 && loho[i].MaLop <= 14) //16340
                        {
                            if (lopmh.MaMH == 11) //Toán 2
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 2) //Anh văn 2
                            {
                                lopmh.SoTiet = 5;
                            }
                            else if (lopmh.MaMH == 8 || lopmh.MaMH == 25) // maclenin,vật lý 1
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 17 || lopmh.MaMH == 20) //gdqp2,gdtc2
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else if (loho[i].MaLop > 14 && loho[i].MaLop <= 16) //16240
                        {
                            if (lopmh.MaMH == 12) //Toán 3
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 2 || lopmh.MaMH == 4) //Anh văn 2 ,av4
                            {
                                lopmh.SoTiet = 3;
                            }
                            else if (lopmh.MaMH == 7 || lopmh.MaMH == 14) // vật lý 1,xs và ud
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 21 || lopmh.MaMH == 16) //gctc3,gdqp1
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else if (loho[i].MaLop > 16 && loho[i].MaLop <= 18) //16430
                        {
                            if (lopmh.MaMH == 12) //Toán 3
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 4 || lopmh.MaMH == 5) //Anh văn 4 ,av5
                            {
                                lopmh.SoTiet = 3;
                            }
                            else if (lopmh.MaMH == 25 || lopmh.MaMH == 14 || lopmh.MaMH == 6) // vật lý 1,xs và ud,tư tưởng hcm
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 21 || lopmh.MaMH == 18) //gctc3,gdqp3
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        else  //16450
                        {
                            if (lopmh.MaMH == 10) //Toán 3
                            {
                                lopmh.SoTiet = 4;
                            }
                            else if (lopmh.MaMH == 4 || lopmh.MaMH == 5) //Anh văn 4 ,av5
                            {
                                lopmh.SoTiet = 3;
                            }
                            else if (lopmh.MaMH == 13 || lopmh.MaMH == 15 || lopmh.MaMH == 9 || lopmh.MaMH == 7) // vật lý 2,ds tuyến tính,pldc,đường lối
                            {
                                lopmh.SoTiet = 3;
                            }
                            else if (lopmh.MaMH == 20 || lopmh.MaMH == 16) //gctc2,gdqp1
                            {
                                lopmh.SoTiet = 2;
                            }
                        }
                        Lop_Monhoc.Add(lopmh);
                        dem++;
                    }
                }


                //Giáo viên nào dạy lớp nào 
                dem = 1;
                Random ra = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        Gv_Lop gvl = new Gv_Lop();
                        gvl.stt = dem;
                        gvl.MaLop = loho[j].MaLop; // tạo danh sách lớp môn học mới
                        gvl.MaMH = moho[i].MaMH;
                        chon = new List<Chon>();
                        int nchon = 0;
                        for (int l = 0; l < GVMHTable.Count - 1; l++)
                        {

                            if (GVMHTable[l].MaMH == gvl.MaMH)
                            {
                                Chon ch = new Chon();
                                ch.stt = nchon; //chọn số lượng môn học
                                ch.MaGV = GVMHTable[l].MaGV;  // kiểm tra xem giáo viên này có phù hợp để dạy môn học này của lớp này hk
                                chon.Add(ch);
                                nchon++;
                            }
                        }

                        int a;
                        if (nchon > 1) a = ra.Next(nchon); // phải nhỏ hơn nchon và lớn hơn 0
                        else a = 0;
                        int magv = chon[a].MaGV; // chọn ngẫu nhiên giáo viên
                        gvl.MaGV = magv; // giảng viên dạy lớp nào rồi
                        for (int l = 0; l < LPTable.Count - 1; l++)
                        {
                            if (LPTable[l].MaLop == loho[j].MaLop)// kiểm tra trùng mã lớp k,,k trùng thì dạy
                            {
                                gvl.MaPH = LPTable[l].MaPH; // 
                                break;
                            }
                        }
                        GiaoVien_LopHoc.Add(gvl);
                        dem++;
                    }

                }
                // lớp đó có môn học đó học bao nhiêu tiết
                int tiet = 0;
                dem = 1;
                Random rd = new Random();
                Random rd1 = new Random();

                for (int it = 0; it < l; it++)
                {
                    List<int> chonMh = new List<int>();
                    int sotiet = 0;
                    for (int i = 0; i < moho.Count - 1; i++)
                    {
                        sotiet = 0;
                        if (moho[i].MaMH != 16 && moho[i].MaMH != 17 && moho[i].MaMH != 18 && moho[i].MaMH != 19 && moho[i].MaMH != 20 && moho[i].MaMH != 21)
                        {
                            for (int j = 0; j < Lop_Monhoc.Count - 1; j++)
                            {
                                if (Lop_Monhoc[j].MaMH == moho[i].MaMH && Lop_Monhoc[j].MaLop == loho[it].MaLop)
                                {
                                    sotiet = Lop_Monhoc[j].SoTiet; // môn đó dạy lớp đó có bao nhiêu tiết
                                    break;
                                }
                            }
                            for (int j = 0; j < sotiet; j++) //Số lần xuất hiện môn học trong List chonMh
                            {
                                chonMh.Add(Lop_Monhoc[i].MaMH);
                            }
                        }

                    }

                    if (Compare(loho[it].TenLop.ToString(), "1611") == true || (Compare(loho[it].TenLop.ToString(), "1613") == true
                        || (Compare(loho[it].TenLop.ToString(), "1645") == true)))
                    {


                        for (int th = 0; th < 6; th++)
                        {
                            for (int i = 1; i <= 5; i++)//lớp buổi sáng
                            {
                                Lop_MonHoc_Tiet lgvmh = new Lop_MonHoc_Tiet();
                                tiet = i + 10 * th;
                                if (tiet == 29 || tiet == 30 || tiet==35)
                                {

                                }
                                else
                                {
                                    int vt;
                                    if (chonMh.Count > 1) // điều kiện bảng chọn môn học 
                                        vt = rd.Next(chonMh.Count - 1); // chọn bất kỳ mã môn học của môn học đã chọn 
                                    else vt = 0;
                                    lgvmh.stt = dem;
                                    lgvmh.MaLop = loho[it].MaLop;
                                    lgvmh.MaMH = chonMh[vt];
                                    lgvmh.MaTiet = tiet;
                                    if (chonMh.Count > 1)
                                        chonMh.RemoveAt(vt); // để k bị trùng
                                    Lop_T_MH.Add(lgvmh);
                                    dem++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int th = 0; th < 6; th++)
                        {

                            for (int i = 6; i <= 10; i++)//lớp buổi chieu
                            {
                                Lop_MonHoc_Tiet lgvmh = new Lop_MonHoc_Tiet();
                                tiet = i + 10 * th;
                                if (tiet == 50 || tiet == 59 || tiet == 60)
                                {

                                }
                                else
                                {
                                    int vt;
                                    if (chonMh.Count > 1) vt = rd1.Next(chonMh.Count - 1);
                                    else vt = 0;
                                    lgvmh.stt = dem;
                                    lgvmh.MaLop = loho[it].MaLop;
                                    lgvmh.MaMH = chonMh[vt];
                                    lgvmh.MaTiet = tiet;
                                    if (chonMh.Count > 1)
                                        chonMh.RemoveAt(vt);
                                    Lop_T_MH.Add(lgvmh);
                                    dem++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message);
            }
    }
        int SoSanh(int s)
        {
            if (s == 21) return 1;  // Hiệu trưởng
            if (s == 22 || s == 23) return 2; // Phó hiệu trưởng
            if (s == 3 || s == 9 || s == 5 || s == 29 || s == 31 || s == 45) return 3; // Trưởng khoa
            if (s == 1 || s == 2 || s == 4 || s == 6 || s == 44 || s == 46 || s == 64 || s == 65) return 4; // Phó Trưởng Khoa
            if (s == 52) return 5; // Trưởng Phụ Trách
            if (s == 53) return 6; // Phó Phụ Trách
            return 0;
        }

        bool Compare(string s1, string s2)
    {
        return s1.Contains(s2);
    }

    public frmXepThoiKhoaBieu()
    {
        InitializeComponent();
    }
    private void btnXepTKB_Click(object sender, EventArgs e)
    {

        try
        {
            if (btnXepTKB.Enabled == true)
            {
                XepTKB();
                btnXepTKB.Enabled = false;
                lblChonlop.Show();
                cmbchonlop.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Xếp lỗi! " + ex.Message);
        }
    }
    public void XepTKB()
    {
        XepThoiKhoaBieuDataContext xl = new XepThoiKhoaBieuDataContext();
        int them = 1;
            for (int i = 0; i < GiaoVien_LopHoc.Count - 1; i++)
            {
                for (int j = 0; j < Lop_T_MH.Count - 1; j++)
                {
                    if (GiaoVien_LopHoc[i].MaLop == Lop_T_MH[j].MaLop && GiaoVien_LopHoc[i].MaMH == Lop_T_MH[j].MaMH)
                    {

                    ThoiKhoaBieu tkb1 = new ThoiKhoaBieu();
                    tkb1.MaGV = GiaoVien_LopHoc[i].MaGV;
                    tkb1.MaLop = GiaoVien_LopHoc[i].MaLop;
                    tkb1.MaMH = GiaoVien_LopHoc[i].MaMH;
                    tkb1.MaTiet = Lop_T_MH[j].MaTiet; // Đổ dữ liệu lên tkb1
                    tkb1.MaPH = GiaoVien_LopHoc[i].MaPH;
                    tkb.Add(tkb1);
                    them++;
                }
            }
        }
        MessageBox.Show("Da xep xong " + them + " tiet hoc!");      
        try
        {
            dgvRangBuoc.Show();
            foreach (DataGridViewRow r in dgvRangBuoc.Rows)
            {
                dgvRangBuoc.Rows.Clear();
            }
            int i = 0;
            for (int k = 0; k < tkb.Count - 1; k++)
            {
                dgvRangBuoc.Rows.Add();
                dgvRangBuoc.Rows[i].Cells[0].Value = tkb[k].MaGV;
                dgvRangBuoc.Rows[i].Cells[1].Value = tkb[k].MaLop;
                dgvRangBuoc.Rows[i].Cells[2].Value = tkb[k].MaMH;
                dgvRangBuoc.Rows[i].Cells[3].Value = tkb[k].MaPH;
                dgvRangBuoc.Rows[i].Cells[4].Value = tkb[k].MaTiet;
                i++;
                xet = 6;
                lbl2.Text = "Tên Lớp";
                lbl3.Text = "Tên MH";
                dgvRangBuoc.Columns[0].HeaderText = "Mã GV";
                dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                dgvRangBuoc.Columns[3].HeaderText = "Mã PH";
                dgvRangBuoc.Columns[4].HeaderText = "Mã Tiết";
            }
            var lop =
                from d in xl.Lops
                select d;
            foreach (var lo in lop)
            {
                cmbchonlop.Items.Add(lo.TenLop);
            }
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl11.Hide();
            lbl22.Hide();
            lbl33.Hide();
            lbl44.Hide();
            lbl55.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show("lỗi! " + ex.Message);
        }
    }
    private void lblGV_MH_MouseClick(object sender, MouseEventArgs e)
    {
        try
        {
            dgvRangBuoc.Show();

            foreach (DataGridViewRow r in dgvRangBuoc.Rows)
            {
                dgvRangBuoc.Rows.Clear();
            }
            int i = 0;
            foreach (Gv_MonHoc a in GVMHTable)
            {
                dgvRangBuoc.Rows.Add();
                dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                dgvRangBuoc.Rows[i].Cells[1].Value = a.MaGV;
                dgvRangBuoc.Rows[i].Cells[2].Value = a.MaMH;
                dgvRangBuoc.Rows[i].Cells[3].Value = a.SoTiet;
                i++;
                xet = 1;
                lbl2.Text = "Tên GV";
                lbl3.Text = "Tên MH";
                lbl4.Text = "Số Tiết";
                dgvRangBuoc.Columns[0].HeaderText = "STT";
                dgvRangBuoc.Columns[1].HeaderText = "Mã GV";
                dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                dgvRangBuoc.Columns[3].HeaderText = "Số tiết";
            }
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl11.Hide();
            lbl22.Hide();
            lbl33.Hide();
            lbl44.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show("lỗi! " + ex.Message);
        }
    }
    private void lblPhongLop_MouseClick(object sender, MouseEventArgs e)
    {
        try
        {
            dgvRangBuoc.Show();
            foreach (DataGridViewRow r in dgvRangBuoc.Rows)
            {
                dgvRangBuoc.Rows.Clear();
            }
            int i = 0;
            foreach (Lop_Phong a in LPTable)
            {
                dgvRangBuoc.Rows.Add();
                dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                dgvRangBuoc.Rows[i].Cells[1].Value = a.MaLop;
                dgvRangBuoc.Rows[i].Cells[2].Value = a.MaPH;
                i++;
                xet = 2;
                lbl2.Text = "Tên Lớp";
                lbl3.Text = "Tên Phòng";
                dgvRangBuoc.Columns[0].HeaderText = "STT";
                dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                dgvRangBuoc.Columns[2].HeaderText = "Mã PH";
                dgvRangBuoc.Columns[3].HeaderText = "";
            }
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl11.Hide();
            lbl22.Hide();
            lbl33.Hide();
            lbl44.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show("lỗi! " + ex.Message);
        }
    }
    private void lblLopMH_MouseClick(object sender, MouseEventArgs e)
    {
        try
        {
            dgvRangBuoc.Show();
            foreach (DataGridViewRow r in dgvRangBuoc.Rows)
            {
                dgvRangBuoc.Rows.Clear();
            }
            int i = 0;
            foreach (Lop_MonHoc a in Lop_Monhoc)
            {
                dgvRangBuoc.Rows.Add();
                dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                dgvRangBuoc.Rows[i].Cells[1].Value = a.MaLop;
                dgvRangBuoc.Rows[i].Cells[2].Value = a.MaMH;
                dgvRangBuoc.Rows[i].Cells[3].Value = a.SoTiet;
                i++;
                xet = 3;
                lbl2.Text = "Tên Lớp";
                lbl3.Text = "Tên MH";
                lbl4.Text = "Số Tiết";
                dgvRangBuoc.Columns[0].HeaderText = "STT";
                dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                dgvRangBuoc.Columns[3].HeaderText = "Số Tiết";
            }
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl11.Hide();
            lbl22.Hide();
            lbl33.Hide();
            lbl44.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show("lỗi! " + ex.Message);
        }
    }
        private void lblGV_Lop_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (Gv_Lop a in GiaoVien_LopHoc)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaGV;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaLop;
                    dgvRangBuoc.Rows[i].Cells[3].Value = a.MaMH;
                    dgvRangBuoc.Rows[i].Cells[4].Value = a.MaPH;
                    i++;
                    xet = 4;
                    lbl2.Text = "Tên GV";
                    lbl3.Text = "Tên Lớp";
                    lbl4.Text = "Tên MH";
                    lbl5.Text = "Tên PH";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã GV";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[3].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[4].HeaderText = "Mã PH";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl5.Hide();
                lbl11.Hide();
                lbl22.Hide();
                lbl33.Hide();
                lbl44.Hide();
                lbl55.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }
        private void lblTiet_MH_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (Lop_MonHoc_Tiet a in Lop_T_MH)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaLop;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaMH;
                    dgvRangBuoc.Rows[i].Cells[3].Value = a.MaTiet;
                    i++;
                    xet = 5;
                    lbl2.Text = "Tên Lớp";
                    lbl3.Text = "Tên MH";
                    lbl4.Text = "Mã Tiết";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[3].HeaderText = "Mã Tiết";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl11.Hide();
                lbl22.Hide();
                lbl33.Hide();
                lbl44.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }
        private void dgvRangBuoc_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        XepThoiKhoaBieuDataContext xl = new XepThoiKhoaBieuDataContext();
        int r = dgvRangBuoc.CurrentCell.RowIndex;
        if (r >= 0 && r < dgvRangBuoc.RowCount)
        {
            switch (xet)
            {
                case 1:
                    {
                        lbl11.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                        string tenGV = null;
                        string TenMH = null;
                        int magv = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                        int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                        var teng =
                            from d in xl.GiaoViens
                            where d.MaGV == magv
                            select d;
                        var tenm =
                            from d in xl.MonHocs
                            where d.MaMH == mamh
                            select d;
                        foreach (var gv in teng)
                        {
                            tenGV = gv.TenGV;
                        }
                        foreach (var mh in tenm)
                        {
                            TenMH = mh.TenMH;
                        }
                        lbl22.Text = tenGV;
                        lbl33.Text = TenMH;
                        lbl44.Text = dgvRangBuoc.Rows[r].Cells[3].Value.ToString();
                        lbl44.Show();
                        lbl4.Show();
                        lbl55.Hide();
                        lbl5.Hide();
                        break;
                    }
                case 2:
                    {
                        lbl11.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                        string tenLop = null;
                        string TenPhong = null;
                        int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                        int maphong = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                        var tenl =
                            from d in xl.Lops
                            where d.MaLop == malop
                            select d;
                        var tenp =
                            from d in xl.PhongHocs
                            where d.MaPH == maphong
                            select d;
                        foreach (var lh in tenl)
                        {
                            tenLop = lh.TenLop;
                        }
                        foreach (var ph in tenp)
                        {
                            TenPhong = ph.TenPH;
                        }
                        lbl22.Text = tenLop;
                        lbl33.Text = TenPhong;
                        lbl44.Hide();
                        lbl4.Hide();
                        lbl55.Hide();
                        lbl5.Hide();
                        break;
                    }
                case 3:
                    {
                        lbl11.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                        string TenLop = null;
                        string TenMH = null;
                        int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                        int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                        var tenl =
                            from d in xl.Lops
                            where d.MaLop == malop
                            select d;
                        var tenm =
                            from d in xl.MonHocs
                            where d.MaMH == mamh
                            select d;
                        foreach (var lh in tenl)
                        {
                            TenLop = lh.TenLop;
                        }
                        foreach (var mh in tenm)
                        {
                            TenMH = mh.TenMH;
                        }
                        lbl22.Text = TenLop;
                        lbl33.Text = TenMH;
                        lbl44.Text = dgvRangBuoc.Rows[r].Cells[3].Value.ToString();
                        lbl44.Show();
                        lbl4.Show();
                        lbl55.Hide();
                        lbl5.Hide();
                        break;
                    }
                case 4:
                    {
                        lbl11.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                        string TenLop = null;
                        string TenMH = null;
                        string TenGV = null;
                        string TenPH = null;
                        int magv = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                        int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                        int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[3].Value.ToString());
                        int maph = Int32.Parse(dgvRangBuoc.Rows[r].Cells[4].Value.ToString());

                        var tenl =
                            from d in xl.Lops
                            where d.MaLop == malop
                            select d;
                        var tenm =
                            from d in xl.MonHocs
                            where d.MaMH == mamh
                            select d;
                        var tengv =
                            from d in xl.GiaoViens
                            where d.MaGV == magv
                            select d;
                        var tenph =
                            from d in xl.PhongHocs
                            where d.MaPH == maph
                            select d;
                        foreach (var lh in tenl)
                        {
                            TenLop = lh.TenLop;
                        }
                        foreach (var mh in tenm)
                        {
                            TenMH = mh.TenMH;
                        }
                        foreach (var gv in tengv)
                        {
                            TenGV = gv.TenGV;
                        }
                        foreach (var ph in tenph)
                        {
                            TenPH = ph.TenPH;
                        }
                        lbl22.Text = TenGV;
                        lbl33.Text = TenLop;
                        lbl44.Text = TenMH;
                        lbl55.Text = TenPH;
                        lbl44.Show();
                        lbl55.Show();
                        lbl4.Show();
                        lbl5.Show();
                        break;
                    }
                case 5:
                    {
                        lbl11.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                        string TenLop = null;
                        string TenMH = null;
                        int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                        int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                        var tenl =
                            from d in xl.Lops
                            where d.MaLop == malop
                            select d;
                        var tenm =
                            from d in xl.MonHocs
                            where d.MaMH == mamh
                            select d;
                        foreach (var lh in tenl)
                        {
                            TenLop = lh.TenLop;
                        }
                        foreach (var mh in tenm)
                        {
                            TenMH = mh.TenMH;
                        }
                        lbl22.Text = TenLop;
                        lbl33.Text = TenMH;
                        lbl44.Text = dgvRangBuoc.Rows[r].Cells[3].Value.ToString();
                        lbl44.Show();
                        lbl4.Show();
                        lbl55.Hide();
                        lbl5.Hide();
                        break;
                    }
                case 6:
                    {
                        lbl11.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                        string TenLop = null;
                        string TenMH = null;
                        string TenGV = null;
                        string TenPH = null;
                        string Time = null;
                        int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                        int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                        int magv = Int32.Parse(dgvRangBuoc.Rows[r].Cells[0].Value.ToString());
                        int maph = Int32.Parse(dgvRangBuoc.Rows[r].Cells[3].Value.ToString());
                        int matiet = Int32.Parse(dgvRangBuoc.Rows[r].Cells[4].Value.ToString());
                        var tenl =
                            from d in xl.Lops
                            where d.MaLop == malop
                            select d;
                        var tenm =
                            from d in xl.MonHocs
                            where d.MaMH == mamh
                            select d;
                        var tengv =
                            from d in xl.GiaoViens
                            where d.MaGV == magv
                            select d;
                        var tenph =
                            from d in xl.PhongHocs
                            where d.MaPH == maph
                            select d;
                        var time =
                            from d in xl.Tiets
                            where d.STT == matiet
                            select d;
                        foreach (var gv in tengv)
                        {
                            TenGV = gv.TenGV;
                        }
                        foreach (var lh in tenl)
                        {
                            TenLop = lh.TenLop;
                        }
                        foreach (var mh in tenm)
                        {
                            TenMH = mh.TenMH;
                        }
                        foreach (var ph in tenph)
                        {
                            TenPH = ph.TenPH;
                        }
                        foreach (var t in time)
                        {
                            Time = t.Time;
                        }
                        lbl11.Text = TenGV;
                        lbl22.Text = TenLop;
                        lbl33.Text = TenMH;
                        lbl44.Text = TenPH;
                        lbl55.Text = Time;
                        lbl44.Show();
                        lbl4.Show();
                        lbl55.Show();
                        lbl5.Show();
                        lbl1.Text = "Tên GV";
                        lbl2.Text = "Tên Lớp";
                        lbl3.Text = "Tên MH";
                        lbl4.Text = "Tên PH";
                        lbl5.Text = "Time";
                        break;
                    }

            }
            lbl1.Show();
            lbl2.Show();
            lbl3.Show();
            lbl11.Show();
            lbl22.Show();
            lbl33.Show();
        }
    }

    private string tenLop = null;
    private int malop = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        tenLop = cmbchonlop.Text;
        malop = cmbchonlop.SelectedIndex + 1;
        MessageBox.Show(malop.ToString());
        btnXuatThoiKhoaBieu.Show();
    }  
        private void frmXepThoiKhoaBieu_Load(object sender, EventArgs e)
        {   
                try
            {
                XThoiKhoaBieu();
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl5.Hide();
                lblChonlop.Hide();
                cmbchonlop.Hide();
                btnXuatThoiKhoaBieu.Hide();
                lbl11.Hide();
                lbl22.Hide();
                lbl33.Hide();
                lbl44.Hide();
                lbl55.Hide();
                dgvRangBuoc.Show();
                dgvRangBuoc.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXuatTKB_Click(object sender, EventArgs e)
        {
            XuatExcel(dgvRangBuoc, tenLop, "THỜI KHÓA BIỂU");
        }
        private void XuatExcel(DataGridView dt, string sheetName, string title)
        {
            // //try
            // //{
            // ////Tạo các đối tượng Excel
            // Microsoft.Office.Interop.Excel.Application xlApp;
            // Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            // Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            // ////
            // //object misValue = System.Reflection.Missing.Value;

            // //xlApp = new Microsoft.Office.Interop.Excel.Application();
            // //xlWorkBook = xlApp.Workbooks.Add(misValue);
            // //xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(numberOfLetters);

            // //foreach (string letter in letters)
            // //{
            // //    xlWorkSheet.Cells[rowIndex, 1] = letter;
            // //    rowIndex++;
            // //}

            // //xlWorkBook.SaveAs(pathXL, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            // //xlWorkBook.Close(true, misValue, misValue);
            // //xlApp.Quit();
           
            app oExcel = new app();
            Workbooks oBooks;
            Sheets oSheets;
            Workbook oBook;
            Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Worksheet)oSheets.get_Item(1);

            // Tạo phần đầu

            Range head = oSheet.get_Range("A1", "F1");
            Range thu2 = oSheet.get_Range("F4", "F7");
            Range thu3 = oSheet.get_Range("F8", "F12");
            Range thu4 = oSheet.get_Range("F13", "F17");
            Range thu5 = oSheet.get_Range("F18", "F22");
            Range thu6 = oSheet.get_Range("F23", "F26");
            Range thu7 = oSheet.get_Range("F27", "F29");

            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Calibri";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu2.MergeCells = true;
            thu2.Value2 = "Thứ 2";
            thu2.Font.Bold = false;
            thu2.Font.Name = "Calibri";
            thu2.Font.Size = "14";
            thu2.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu3.MergeCells = true;
            thu3.Value2 = "Thứ 3";
            thu3.Font.Bold = false;
            thu3.Font.Name = "Calibri";
            thu3.Font.Size = "14";
            thu3.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu4.MergeCells = true;
            thu4.Value2 = "Thứ 4";
            thu4.Font.Bold = false;
            thu4.Font.Name = "Calibri";
            thu4.Font.Size = "14";
            thu4.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu5.MergeCells = true;
            thu5.Value2 = "Thứ 5";
            thu5.Font.Bold = false;
            thu5.Font.Name = "Calibri";
            thu5.Font.Size = "14";
            thu5.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu6.MergeCells = true;
            thu6.Value2 = "Thứ 6";
            thu6.Font.Bold = false;
            thu6.Font.Name = "Calibri";
            thu6.Font.Size = "14";
            thu6.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            thu7.MergeCells = true;
            thu7.Value2 = "Thứ 7";
            thu7.Font.Bold = false;
            thu7.Font.Name = "Calibri";
            thu7.Font.Size = "14";
            thu7.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            List<Range> cl = new List<Range>();
            // Tạo tiêu đề cột
            Range cli;

            cli = oSheet.get_Range("A3","A3");
            cli.Value2 = "Tên Giáo Viên";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("B3","B3");
            cli.Value2 = "Tên Lớp";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("C3","C3");
            cli.Value2 = "Tên Môn Học";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("D3","D3");
            cli.Value2 = "Tên Phòng Học";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("E3","E3");
            cli.Value2 = "Thời Gian";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("F3","F3");
            cli.Value2 = "Ngày Học";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            var thoikb =
                  from d in tkb
                  where d.MaLop == malop
                  orderby d.MaTiet
                  select d;

            Range rowHead = oSheet.get_Range("A3", "F3");

            rowHead.Font.Bold = true;
            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[30, 5];

            //Chuyển dữ liệu từ Datagridview vào mảng đối tượng
            int r = 0;
            foreach (var lh in thoikb)
            {
                XepThoiKhoaBieuDataContext xl = new XepThoiKhoaBieuDataContext();
                string TenMH = null;
                string TenGV = null;
                string TenPH = null;
                string Time = null;
                int mamh = lh.MaMH;
                int magv = lh.MaGV;
                int maph = lh.MaPH;
                int matiet = lh.MaTiet;
                var tenm =
                    from d in xl.MonHocs
                    where d.MaMH == mamh
                    select d;
                var tengv =
                    from d in xl.GiaoViens
                    where d.MaGV == magv
                    select d;
                var tenph =
                    from d in xl.PhongHocs
                    where d.MaPH == maph
                    select d;
                var time =
                    from d in xl.Tiets
                    where d.STT == matiet
                    select d;
                foreach (var gv in tengv)
                {
                    TenGV = gv.TenGV;
                }
                foreach (var mh in tenm)
                {
                    TenMH = mh.TenMH;
                }
                foreach (var ph in tenph)
                {
                    TenPH = ph.TenPH;
                }
                foreach (var t in time)
                {
                    Time = t.Time;
                }
                arr[r, 0] = TenGV.ToString();
                arr[r, 1] = tenLop.ToString();
                arr[r, 2] = TenMH.ToString();
                arr[r, 3] = TenPH.ToString();
                arr[r, 4] = Time.ToString();
                r++;
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + 25;
            int columnEnd = 5;

            // Ô bắt đầu điền dữ liệu

            Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Constants.xlSolid;

            // Căn giữa cột Thứ

            Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

            Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;
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




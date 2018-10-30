using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_1
{
   public class XepThoiKhoaBieu
    {
        public List<Gv_MonHoc> gvmonhoc { get; set; }
        public List<Lop_Phong> lopphong { get; set; }

        public List<Lop_MonHoc> lopmonhoc { get; set; }
        public XepThoiKhoaBieu()
        {
            XepThoiKhoaBieuDataContext xl = new XepThoiKhoaBieuDataContext();
            List<GiaoVien> GV = new List<GiaoVien>();
            List<MonHoc> MH = new List<MonHoc>();
            List<Lop> LOP = new List<Lop>();
            List<PhongHoc> PHONG = new List<PhongHoc>();
            gvmonhoc = new List<Gv_MonHoc>();
            lopphong = new List<Lop_Phong>();
            int g;
            int m;
            int l;
            int p;
            var gvien =
                from d in xl.GiaoViens
                select d;
            var mhoc =
                from d in xl.MonHocs
                select d;
            var lop =
                from d in xl.Lops
                select d;
            var phong =
                from d in xl.PhongHocs
                select d;

            foreach (var b in gvien)
            {
                g = 0;
                GiaoVien gv = new GiaoVien();
                gv.MaGV = b.MaGV;
                gv.TenGV = b.TenGV;
                gv.MaBM = b.MaBM;
                GV.Add(gv);
                g++;
            }
            foreach (var b in mhoc)
            {
                m = 0;
                MonHoc mh = new MonHoc();
                mh.MaMH = b.MaMH;
                mh.TenMH = b.TenMH;
                mh.MaBM = b.MaBM;
                MH.Add(mh);
                m++;
            }
            foreach (var b in lop)
            {
                l = 0;
                Lop lo = new Lop();
                lo.MaLop = b.MaLop;
                lo.TenLop = b.TenLop;
                LOP.Add(lo);
                l++;
            }
            foreach (var b in phong)
            {
                p = 0;
                PhongHoc ph = new PhongHoc();
                ph.MaPH = b.MaPH;
                ph.TenPH = b.TenPH;
                PHONG.Add(ph);
                p++;
            }
           
        }
        bool Compare(string s1, string s2)
        {
            return s1.Contains(s2);
        }

    }
}

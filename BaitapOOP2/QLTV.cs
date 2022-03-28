using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapOOP2
{
    public class QLTV
    {
        public int MaTL { get; set; }
        public string TenNhaXB { get; set; }
        public int SoBanPH { get; set; }
        public void In()
        {
            Console.WriteLine("Mã tài liệu: {0} -- Tên nhà Xuất Bản: {1}-- Số xuất bản: {2}", MaTL, TenNhaXB, SoBanPH);
        }

    }

    public class Sach :QLTV
    {
        public string TenTG { get; set; }
        public int SoTrang { get; set; }
        public void Insach()
        {
            Console.WriteLine("Mã tài liệu: {0}  -- Tên nhà Xuất Bản: {1}-- Số xuất bản: {2}--Tên tác giả: {3}-- Số trang: {4}", MaTL, TenNhaXB, SoBanPH, TenTG, SoTrang);
        }
    }
  
    public class Tapchi : QLTV
    {
        public int SoPH { get; set; }
        public DateTime ThangPH { get; set; }
        public void In()
        {
            Console.WriteLine("Mã tài liệu: {0} -- Số phát hành: {1} -- Tên nhà Xuất Bản: {2}-- Số xuất bản: {3} -- tháng phát hành: {4}", MaTL, SoPH, TenNhaXB, SoBanPH, ThangPH);
        }
    }
    public class Bao : QLTV
    {
        public DateTime NgayPH { get; set; }
        public void In()
        {
            Console.WriteLine("Mã tài liệu: {0} -- Tên nhà Xuất Bản: {1}-- Số xuất bản: {2}-- Ngày phát hành: {3}", MaTL, TenNhaXB, SoBanPH, NgayPH);
        }
    }
    public class chucnangsach
    {
        ArrayList Ds = new ArrayList();
        public void AddSach(Sach S)
        {
            Ds.Add(S);
        }
        public void DeleteSach(int maTL)
        {
            Sach sach = new Sach();
            foreach (Sach S in Ds)
            {
                if (maTL == S.MaTL)
                {
                    sach = S;
                }
            }
            Ds.Remove(sach);
        }
        public void UpdateSach(int maTL, string tenNhaXB, int soBanPH, string tenTG, int soTrang)
        {
            foreach (Sach S in Ds)
            {
                if (S.MaTL == maTL)
                {
                    S.TenNhaXB = tenNhaXB;
                    S.SoBanPH = soBanPH;
                    S.TenTG = tenTG;
                    S.SoTrang = soTrang;
                }
            }
        }
        public Sach Search(int maTL)
        {
            Sach sach = new Sach();
            foreach (Sach S in Ds)
            {
                if (S.MaTL == maTL)
                {
                    sach = S;
                }
            }
            return sach;
        }
        public void hienthi()
        {
            foreach (Sach S in Ds)
            {
                S.Insach();
            }
        }
    }
}

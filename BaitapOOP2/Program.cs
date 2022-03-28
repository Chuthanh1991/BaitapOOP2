using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QLTV chucnang = new QLTV();
            int maTL;
            string tenNhaXB;
            int soBanPH;
            string tenTG;
            int soTrang;
            int SoPH;
            DateTime ThangPH;
            DateTime NgayPH;
            chucnangsach chucnangsach = new chucnangsach();
            do
            {
                Console.WriteLine("Chọn chức năng");
                Console.WriteLine("1. Quản lý các tài liệu Sách");
                Console.WriteLine("2. Quản lý các tài liệu Tạp chí");
                Console.WriteLine("3. Quản lý các tài liệu Báo");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        do
                        {
                            
                            Console.WriteLine("a. THÊM Sách");
                            Console.WriteLine("b. XOÁ Sách");
                            Console.WriteLine("c. CẬP NHẬT Sách");
                            Console.WriteLine("d. TÌM KIẾM Sách");
                            Console.WriteLine("e. HIỆN THỊ DANH SÁCH");
                            string chon1 = Console.ReadLine();
                            switch (chon1)
                            {
                                case "a":
                                    Console.WriteLine("Nhập Mã Sách:");
                                    maTL = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Nhập Tên nhà Xuất Bản:");
                                    tenNhaXB = Console.ReadLine();
                                    Console.WriteLine("Nhập số phát hành :");
                                    soBanPH = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Nhập tên tác giả:");
                                    tenTG = Console.ReadLine();
                                    Console.WriteLine("Nhập số trang:");
                                    soTrang = Int32.Parse(Console.ReadLine());
                                    Sach sach = new Sach();
                                    sach.MaTL = maTL;
                                    sach.TenNhaXB = tenNhaXB;
                                    sach.SoBanPH = soBanPH;
                                    sach.TenTG = tenTG;
                                    sach.SoTrang = soTrang;
                                    chucnangsach.AddSach(sach);
                                    break;
                                case "b":
                                    Console.WriteLine("Nhập Mã Sách:");
                                    maTL = Int32.Parse(Console.ReadLine());
                                    chucnangsach.DeleteSach(maTL);
                                    break;
                                case "c":
                                    Console.WriteLine("Nhập Mã Sách:");
                                    maTL = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Nhập Tên nhà Xuất Bản:");
                                    tenNhaXB = Console.ReadLine();
                                    Console.WriteLine("Nhập số phát hành :");
                                    soBanPH = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Nhập tên tác giả:");
                                    tenTG = Console.ReadLine();
                                    Console.WriteLine("Nhập số trang:");
                                    soTrang = Int32.Parse(Console.ReadLine());
                                    chucnangsach.UpdateSach(maTL, tenNhaXB, soBanPH, tenTG, soTrang);
                                    break;
                                case "d":
                                    Console.WriteLine("Nhập Mã Sách:");
                                    maTL = Int32.Parse(Console.ReadLine());
                                    chucnangsach.Search(maTL);
                                    break;
                                case "e":
                                  chucnangsach.hienthi();
                                    break;
                            }
                        }
                        while (true);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            } while (true);
        }
    }
}

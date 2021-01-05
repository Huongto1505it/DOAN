using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.BusinessLayer;
namespace DOAN1.Presenation
{
    public class FmNhanvien
    {
        private INhanvienBLL nvbll = new NhanvienBLL();
        public void Nhap()
        {
            do
            {
                Console.Clear();
            Console.WriteLine("Nhap thong tin nhan vien");
            
                Nhanvien nv = new Nhanvien();
                Console.Write("Nhap ma nhan vien:"); nv.Manv = Console.ReadLine();
                Console.Write("Nhap ten nhan vien:"); nv.Tennv = Console.ReadLine();
                Console.Write("Nhap dia chi:"); nv.Diachi = Console.ReadLine();
                Console.Write("Nhap so dien thoai:"); nv.SDT = Console.ReadLine();
                nvbll.themNhanvien(nv);
                Console.WriteLine("Ban co muon nhap tiep c/k");
                ConsoleKeyInfo k2 = Console.ReadKey();
                if (k2.KeyChar == 'K' || k2.KeyChar == 'k')
                {
                    break;
                }
            } while (true);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("THONG TIN NHAN VIEN");
            List<Nhanvien> list = nvbll.GetALLMH();
            foreach (var x in list)

                Console.WriteLine(x.Manv + "\t" + x.Tennv + "\t" + x.Diachi + "\t" + x.SDT);

        }
        public void Sua()
        {
            //Console.Clear();
            Console.WriteLine("SỬA THÔNG TIN NHÂN VIÊN");
            List<Nhanvien> list = nvbll.GetALLMH();
            string maNhanvien;
            Console.Write("Nhập mã nhân viên cần sửa:"); maNhanvien = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Manv == maNhanvien) break;

            if (i < list.Count)
            {
                Nhanvien nv = new Nhanvien();
                Console.Write("Nhập tên mới:"); string ten = Console.ReadLine();
                if (ten != "") nv.Tennv = ten;
                Console.Write("Nhập địa chỉ:"); string diachi = Console.ReadLine();
                if (diachi != "") nv.Diachi = diachi;
                Console.Write("Nhập số điện thoại:"); string sdt = Console.ReadLine();
                if (sdt != "") nv.SDT = sdt;
                nvbll.SuaNhanvien(nv);
            }
            else Console.WriteLine("Mã nhân viên không tồn tại");
        }
        public void Xoa()
        {
            //Console.Clear();
            Console.WriteLine("Xoa thong tin nhan vien");
            List<Nhanvien> list = nvbll.GetALLMH();
            Console.Write("Nhap ma nhan vien can xoa:"); string maNhanvien= Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Manv == maNhanvien) break;
            if (i < list.Count)
            {
                nvbll.XoaNhanvien(maNhanvien);

            }
            else Console.WriteLine("khach hang nay k ton tai");
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("TÌM KIẾM NHÂN VIÊN");
            List<Nhanvien> list = nvbll.GetALLMH();

            Console.WriteLine("Nhap thong tin nhan vien can tim kiem"); string tt = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Manv == tt || list[i].Tennv == tt || list[i].Diachi == tt) break;
            if (i < list.Count)
            {
                List<Nhanvien> grt = nvbll.TimkiemNhanvien(new Nhanvien(list[i]));
                foreach (var x in grt)

                    Console.WriteLine(x.Manv + "\t" + x.Tennv + "\t" + x.Diachi + "\t" + x.SDT);
            }

            else Console.WriteLine("Thong tin nhan vien  nay k ton tai");


        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                                   ____________________________________________________________________");
                Console.WriteLine("                                   |                   QUAN LY THONG TIN NHAN VIEN                  |");
                Console.WriteLine("                                   |          F1.Nhập thông tin nhân viên                           |");
                Console.WriteLine("                                   |          F2.Sửa thông tin nhân viên                            |");
                Console.WriteLine("                                   |          F3.Xóa nhân viên                                      |");
                Console.WriteLine("                                   |          F4.Hiện thị thông tin nhân viên                       |");
                Console.WriteLine("                                   |          F5.Tìm kiếm nhân viên                                 |");
                Console.WriteLine("                                   |          F6.Back                                               |");
                Console.WriteLine("                                   |________________________________________________________________|");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Nhap(); Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F2:
                         Hien(); Sua();
                        Console.WriteLine("ĐÃ SỬA THÀNH CÔNG!");
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F3:
                         Hien(); Xoa();
                        Console.WriteLine("ĐÃ XÓA THÀNH CÔNG!");
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F5:
                        Console.WriteLine("Mat hang can tim ");
                        TimKiem();

                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F4:
                        Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F6:
                        Program.Menu1();
                        break;
                }

            } while (true);
        }
    }
}

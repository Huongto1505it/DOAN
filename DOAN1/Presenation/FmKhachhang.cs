using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.BusinessLayer;
namespace DOAN1.Presenation
{
    public class FmKhachhang
    {
        private IKhachhangBLL mhbll = new KhachhangBLL();
        public void Nhap()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Nhap thong tin khach hang");
                Khachhang kh = new Khachhang();
                Console.Write("Nhap ma khach hang:"); kh.Makh = Console.ReadLine();
                Console.Write("Nhap ten khach hang:"); kh.Tenkh = Console.ReadLine();
                Console.Write("Nhap dia chi:"); kh.Diachi = Console.ReadLine();
                Console.Write("Nhap so dien thoai:"); kh.SDT = Console.ReadLine();
                mhbll.themkhachhang(kh);
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
            Console.WriteLine("THONG TIN KHACH HANG");
            List<Khachhang> list = mhbll.GetALLMH();
            foreach (var x in list)

                Console.WriteLine(x.Makh + "\t" + x.Tenkh + "\t" + x.Diachi + "\t" + x.SDT);

        }
        public void Sua()
        {
            //Console.Clear();
            Console.WriteLine("Sua thong tin khach hang");
            List<Khachhang> list = mhbll.GetALLMH();
            string maKhachhang;
            Console.Write("Nhap ma khach hang can sua:"); maKhachhang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Makh == maKhachhang) break;

            if (i < list.Count)
            {
                Khachhang kh = new Khachhang(list[i]);
                Console.Write("Nhap ten moi:"); string ten = Console.ReadLine();
                if (ten != "") kh.Tenkh = ten;
                Console.Write("Nhap dia chi:"); string diachi = Console.ReadLine();
                if (diachi != "") kh.Diachi = diachi;
                Console.Write("Nhap so dien moi:"); string sdt = Console.ReadLine();
                if (sdt != "") kh.SDT = sdt;
                mhbll.Suakhachhang(kh);
            }
            //else Console.WriteLine("Khach hang nay k ton tai");
        }
        public void Xoa()
        {
            //Console.Clear();
            Console.WriteLine("Xoa thong tin khach hang");
            List<Khachhang> list = mhbll.GetALLMH();
            Console.Write("Nhap ma khach hang can xoa:"); string maKhachhang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Makh == maKhachhang) break;
            if (i < list.Count)
            {
                mhbll.Xoakhachhang(maKhachhang);

            }
            else Console.WriteLine("khach hang nay k ton tai");
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Tim tiem khach hang");
            List<Khachhang> list = mhbll.GetALLMH();

            Console.WriteLine("Nhap thong tin khach hang can tim kiem"); string tt = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Makh == tt || list[i].Tenkh == tt || list[i].Diachi == tt) break;
            if (i < list.Count)
            {
                List<Khachhang> grt = mhbll.Timkiemkhachhang(new Khachhang(list[i]));
                foreach (var x in grt)

                    Console.WriteLine(x.Makh + "\t" + x.Tenkh + "\t" + x.Diachi + "\t" + x.SDT);
            }

            else Console.WriteLine("Thong tin khach hang  nay k ton tai");


        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                                   ____________________________________________________________________");
                Console.WriteLine("                                   |                   QUAN LY THONG TIN KHACH HANG                  |");
                Console.WriteLine("                                   |          F1.Nhập thông tin khách hàng                           |");
                Console.WriteLine("                                   |          F2.Sửa thông tin khách hàng                            |");
                Console.WriteLine("                                   |          F3.Xóa khách hàng                                      |");
                Console.WriteLine("                                   |          F4.Hiện thị thông tin khách hàng                       |");
                Console.WriteLine("                                   |          F5.Tìm kiếm khách hàng                                 |");
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

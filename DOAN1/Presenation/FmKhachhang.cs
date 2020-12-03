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
            Console.Clear();
            Console.WriteLine("Nhap thong tin khach hang");
            Khachhang kh = new Khachhang();
            Console.Write("Nhap ten khach hang:"); kh.Tenkh = Console.ReadLine();
            Console.Write("Nhap dia chi:"); kh.Diachi = Console.ReadLine();
            Console.Write("Nhap so dien thoai:"); kh.SDT = Console.ReadLine();
            mhbll.themkhachhang(kh);
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
            Console.Clear();
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
            else Console.WriteLine("Khach hang nay k ton tai");
        }
        public void Xoa()
        {
            Console.Clear();
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
                Console.WriteLine("        THONG TIN KHACH HANG     ");
                Console.WriteLine("F1. Nhap khach hang ");
                Console.WriteLine("F2. Sua khach hang ");
                Console.WriteLine("F3. Xoa khach hang ");
                Console.WriteLine("F4. Tim kiem khach hang ");
                Console.WriteLine("F5. Hien thi khach hang ");
                Console.WriteLine("F6. Thoat.... ");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Nhap(); Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F2:
                        Sua(); Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F3:
                        Xoa(); Hien();
                        Console.WriteLine("Da xoa thanh cong!");
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F4:
                        Console.WriteLine("Mat hang can tim ");
                        TimKiem();

                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F5:
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

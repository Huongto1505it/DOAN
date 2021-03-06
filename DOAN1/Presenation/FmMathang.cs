﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.BusinessLayer;
namespace DOAN1.Presenation
{
    public class FmMathang
    {
        
        private IMathangBLL mhbll = new MathangBLL();
        public  void Nhap()
        {
            do
            {
                
                Console.WriteLine("Nhap thong tin mat hang");
                Mathang mh = new Mathang();
                Console.Write("Nhap ma mat hang:"); mh.Mamh = Console.ReadLine();
                Console.Write("Nhap ten mat hang:"); mh.Tenmh = Console.ReadLine();
                Console.Write("Nhap the loai:"); mh.Theloai = Console.ReadLine();
                Console.Write("Nhap don gia:"); mh.Dongia = int.Parse(Console.ReadLine());
                mhbll.themmathang(mh);
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
            Console.WriteLine("THONG TIN MAT HANG");
            List<Mathang> list = mhbll.GetALLMH();
            foreach (var x in list)
                
                Console.WriteLine(x.Mamh + "\t" + x.Tenmh + "\t" + x.Theloai + "\t" + x.Dongia);

        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("Sua thong tin mat hang");
            List<Mathang> list = mhbll.GetALLMH();
            string mamathang;
            Console.Write("Nhap ma mat hang can sua:"); mamathang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Mamh == mamathang) break;

            if (i < list.Count)
            {
                Mathang mh = new Mathang(list[i]);
                Console.Write("Nhap ten moi:"); string ten = Console.ReadLine();
                if (ten != "") mh.Tenmh = ten;
                Console.Write("Nhap the loai:"); string theloai = Console.ReadLine();
                if (theloai != "") mh.Theloai = theloai;
                Console.Write("Nhap don gia moi:"); int dongia = int.Parse(Console.ReadLine());
                if (dongia > 0) mh.Dongia = dongia;
                mhbll.SuaMathang(mh);
            }
            else  Console.WriteLine("Mat hang nay k ton tai"); 
        }
        public void Xoa()
        {
            //Console.Clear();
            Console.WriteLine("Xoa thong tin mat hang");
            List<Mathang> list = mhbll.GetALLMH();
            Console.Write("Nhap ma mat hang can xoa:"); string mamathang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mamh == mamathang) break;
            if (i <= list.Count)
            {
                mhbll.XoaMathang(mamathang);

            }
            else Console.WriteLine("Mat hang nay k ton tai");
        }
        public void TimKiem()
        {
            //Console.Clear();
            Console.WriteLine("Tim tiem mat hang");
            List<Mathang> list = mhbll.GetALLMH();
           
            Console.WriteLine("Nhap thong tin mat hang can tim kiem"); string tt = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mamh == tt || list[i].Tenmh==tt ||list[i].Theloai==tt ) break;
            if (i < list.Count)
            {
                List<Mathang> grt = mhbll.Timkiemmathang(new Mathang(list[i]));
                foreach (var x in grt)

                    Console.WriteLine(x.Mamh + "\t" + x.Tenmh + "\t" + x.Theloai + "\t" + x.Dongia);
            }

            else Console.WriteLine("Thong tin mat hang  nay k ton tai"); 
            
            
        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                                   ____________________________________________________________________");
                Console.WriteLine("                                   |                   QUAN LY THONG TIN MAT HANG                 |");
                Console.WriteLine("                                   |          F1.Nhập thông tin về mặt hàng                       |");
                Console.WriteLine("                                   |          F2.Sửa mã mặt hàng                                  |");
                Console.WriteLine("                                   |          F3.Xóa mặt hàng                                     |");
                Console.WriteLine("                                   |          F4.Hiện thị danh sách mặt hàng                      |");
                Console.WriteLine("                                   |          F5.Tìm kiếm thông tin mặt hàng                      |");
                Console.WriteLine("                                   |          F6.Back                                             |");
                Console.WriteLine("                                   |______________________________________________________________|");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Hien(); Nhap();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F2:
                        Sua();Console.WriteLine("Da sua thanh cong"); Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F3:
                        Xoa();
                        Console.WriteLine("ĐÃ XÓA THÀNH CÔNG!"); Hien();
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

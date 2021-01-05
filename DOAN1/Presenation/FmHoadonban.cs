using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.BusinessLayer;
using DOAN1.Entities;
namespace DOAN1.Presenation
{
    public class FmHoadonban
    {
        private IHoadonbanBLL hdnbll = new HoadonbanBLL();
        public void Nhap()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("THONG TIN HOA DON BAN");
                Hoadonban hd = new Hoadonban();
                Console.Write("Nhap ma hoa don:"); hd.Mahdb = Console.ReadLine();
                INhanvienBLL nv = new NhanvienBLL();
                List<Nhanvien> nv1 = nv.GetALLMH();
                Console.Write("Nhap ma nhan vien :"); hd.Manv = Console.ReadLine();
                int i;
                for (i = 0; i < nv1.Count; i++)
                    if (hd.Manv == nv1[i].Manv) break;
                if (i < nv1.Count)
                {
                }
                else
                {
                    Console.WriteLine("Ten nhan vien khong ton tai"); break;
                }
                IKhachhangBLL kh = new KhachhangBLL();
                List<Khachhang> kh1 = kh.GetALLMH();
                FmKhachhang kh2 = new FmKhachhang();
                Console.Write("Nhap ma khach hang:"); hd.Makh = Console.ReadLine();

                for (i = 0; i < kh1.Count; i++)
                    if (hd.Makh == kh1[i].Makh) break;
                if (i < kh1.Count)
                {
                }
                else
                {
                    Console.WriteLine("Ma khach khong ton tai");
                    kh2.Nhap();
                }
                Console.Write("Ghi chu:"); hd.Ghichu = Console.ReadLine();
                hd.Ngayban = DateTime.Now;
                hdnbll.themHoadonban(hd);
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
            Console.WriteLine("THONG TIN HOA DON BAN");
            List<Hoadonban> list = hdnbll.GetALLMH();
            foreach (var x in list)

                Console.WriteLine(x.Mahdb + "\t" + x.Manv + "\t" + x.Makh + "\t" + x.Ghichu + "\t" +x.Ngayban );

        }
        public void Sua()
        {
            //Console.Clear();
            Console.WriteLine("Sua thong tin hoa don ban");
            List<Hoadonban> list = hdnbll.GetALLMH();
            string mahoadon;
            Console.Write("Nhap ma hoa don can sua:"); mahoadon = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Mahdb == mahoadon) break;

            if (i < list.Count)
            {
               // Console.WriteLine(list[i].Mahdb + "\t" + list[i].Manv + "\t" +list[i].Makh +"\t" +list[i].Ghichu+"\t"+ list[i].Ngayban );

                Hoadonban kh = new Hoadonban(list[i]);
                Console.Write("Nhap ma nhan vien nhan moi:"); string tenvn = Console.ReadLine();
                if (tenvn != kh.Manv) kh.Manv = tenvn;
                Console.Write("Nhap ma khach hang:"); string makh = Console.ReadLine();
                if (makh != kh.Makh) kh.Makh = makh;
                Console.Write("Nhap Ghi chu:"); string gc = Console.ReadLine();
                if (gc != kh.Ghichu) kh.Ghichu = gc;
                kh.Ngayban = DateTime.Now;
                hdnbll.SuaHoadonban(kh);
            }
            else Console.WriteLine("Hoa don nay k ton tai");
        }
        public void Xoa()
        {
            //Console.Clear();

            List<Hoadonban> list = hdnbll.GetALLMH();
            Console.Write("Nhap ma hoa don can xoa:"); string mahb = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mahdb == mahb) break;
            if (i < list.Count)
            {
                hdnbll.XoaHoadonban(mahb);

            }
            else Console.WriteLine("Hoa don nay k ton tai");
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Tim kiem hoa don nhap theo ten hoa don , ma nha cung cap ten nhan vien va ma hoa don");
            List<Hoadonban> list = hdnbll.GetALLMH();

            Console.WriteLine("Nhap thong tin hoa don can tim kiem"); string tt = Console.ReadLine();
            int i = 0;

            for (i = 0; i < list.Count; i++)

                if (list[i].Mahdb == tt || list[i].Manv == tt || list[i].Makh == tt ) break;
            if (i < list.Count)
            {
                List<Hoadonban> grt = hdnbll.TimkiemHoadonban(new Hoadonban(list[i]));
                foreach (var x in grt)

                    Console.WriteLine(x.Mahdb + "\t" + x.Manv + "\t" + x.Makh + "\t"  + x.Ghichu+"\t"+x.Ngayban);
            }

            else Console.WriteLine("Thong tin hoa don nay k ton tai");
        }
        public void Chitiethoadon()
        {
            IChitiethoadonbanBLL ht = new ChitiethoadonbanBLL();
            List<Hoadonban> list = hdnbll.GetALLMH();
            List<Chitiethoadonban> list1 = ht.GetALLMH();
            Console.WriteLine("Nhap ma hoa don can xem chi tiet: "); string mahd = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Mahdb == mahd)
                {
                    Console.WriteLine(list[i].Mahdb + "\t" + list[i].Manv + "\t" + list[i].Makh + "\t" + list[i].Ghichu + "\t" + list[i].Ngayban);
                    
                }
            }
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1[j].Mahdb == mahd)
                {
                    Console.WriteLine(list1[j].Mahdb + "\t" + list1[j].Mamh + "\t" + list1[j].Tenmh + "\t" + list1[j].Theloai + "\t" + list1[j].Dongia + "\t" + list1[j].Soluong + "\t" + list1[j].KM + "\t" + list1[j].Thanhtien);
                    
                }
            }
        }
                public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                                   ____________________________________________________________________");
                Console.WriteLine("                                   |                   QUAN LY THONG TIN HOA DON BAN                 |");
                Console.WriteLine("                                   |          F1.Nhập thông tin hóa đơn bán                          |");
                Console.WriteLine("                                   |          F2.Sửa thông tin hóa đơn bán                           |");
                Console.WriteLine("                                   |          F3.Xóa hóa đơn bán                                     |");
                Console.WriteLine("                                   |          F4.Hiện thị thông tin hóa đơn bán                      |");
                Console.WriteLine("                                   |          F5.Tìm kiếm hóa đơn bán                                |");
                Console.WriteLine("                                   |          F6.Back                                                |");
                Console.WriteLine("                                   |_________________________________________________________________|");
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

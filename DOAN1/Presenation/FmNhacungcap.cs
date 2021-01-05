using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.BusinessLayer;
namespace DOAN1.Presenation
{
    public class FmNhacungcap
    {
        private INhacungcapBLL mhbll = new NhacungcapBLL();
        public void Nhap()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Nhap thong tin nha cung cap");
                Nhacungcap ncc = new Nhacungcap();
                Console.Write("Nhap ma nha cung cap:"); ncc.Mancc = Console.ReadLine();
                Console.Write("Nhap ten nha cung cap:"); ncc.Tenncc = Console.ReadLine();
                Console.Write("Nhap dia chi:"); ncc.Diachi = Console.ReadLine();
                Console.Write("Nhap so dien thoai:"); ncc.SDT = Console.ReadLine();
                mhbll.themNhacungcap(ncc);
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
            Console.WriteLine("THONG TIN NHA CUNG CAP");
            List<Nhacungcap> list = mhbll.GetALLMH();
            foreach (var x in list)

                Console.WriteLine(x.Mancc + "\t" + x.Tenncc + "\t" + x.Diachi + "\t" + x.SDT);

        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("Sua thong tin nha cung cap");
            List<Nhacungcap> list = mhbll.GetALLMH();
            string maNhacungcap;
            Console.Write("Nhap ma nha cung cap can sua:"); maNhacungcap = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Mancc == maNhacungcap) break;

            if (i < list.Count)
            {
                Nhacungcap ncc = new Nhacungcap(list[i]);
                Console.Write("Nhap ten moi:"); string ten = Console.ReadLine();
                if (ten != "") ncc.Tenncc = ten;
                Console.Write("Nhap dia chi:"); string diachi = Console.ReadLine();
                if (diachi != "") ncc.Diachi = diachi;
                Console.Write("Nhap so dien moi:"); string sdt = Console.ReadLine();
                if (sdt != "") ncc.SDT = sdt;
                mhbll.SuaNhacungcap(ncc);
            }
            else Console.WriteLine("Nha cung cap nay k ton tai");
        }
        public void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Xoa thong tin nha cung cap");
            List<Nhacungcap> list = mhbll.GetALLMH();
            Console.Write("Nhap ma nha cung cap can xoa:"); string maNhacungcap = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mancc == maNhacungcap) break;
            if (i < list.Count)
            {
                mhbll.XoaNhacungcap(maNhacungcap);

            }
            else Console.WriteLine("Nha cung cap nay k ton tai");
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Tim tiem nha cung cap");
            List<Nhacungcap> list = mhbll.GetALLMH();

            Console.WriteLine("Nhap thong tin nha cung cap can tim kiem"); string tt = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mancc == tt || list[i].Tenncc == tt || list[i].Diachi == tt) break;
            if (i < list.Count)
            {
                List<Nhacungcap> grt = mhbll.TimkiemNhacungcap(new Nhacungcap(list[i]));
                foreach (var x in grt)

                    Console.WriteLine(x.Mancc + "\t" + x.Tenncc + "\t" + x.Diachi + "\t" + x.SDT);
            }

            else Console.WriteLine("Thong tin nha cung cap  nay k ton tai");


        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                                   ____________________________________________________________________");
                Console.WriteLine("                                   |                   QUAN LY THONG TIN NHA CUNG CAP                 |");
                Console.WriteLine("                                   |          F1.Nhập thông tin về nhà cung cấp                       |");
                Console.WriteLine("                                   |          F2.Sửa mã nhà cung cấp                                  |");
                Console.WriteLine("                                   |          F3.Xóa nhà cung cấp                                     |");
                Console.WriteLine("                                   |          F4.Hiện thị danh sách nhà cung cấp                      |");
                Console.WriteLine("                                   |          F5.Tìm kiếm thông tin nhà cung cấp                      |");
                Console.WriteLine("                                   |          F6.Back                                                 |");
                Console.WriteLine("                                   |__________________________________________________________________|");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Nhap(); Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F2:
                        Hien(); Sua();
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

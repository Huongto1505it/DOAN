using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.BusinessLayer;
using DOAN1.DataAccessLayer;
using DOAN1.Entities;
namespace DOAN1.Presenation
{
   public class FmChitiethoadonnhap
    {
        public IChitiethoadonnhapBLL bl = new ChitiethoadonnhapBLL();
        private IMathangBLL mhbll = new MathangBLL();
        public void Nhap()
        {
            Console.Clear();
            List<Mathang> list = mhbll.GetALLMH();
            Chitiethoadonnhap h = new Chitiethoadonnhap();
            IHoadonnhapBLL ncc = new HoadonnhapBLL();
            List<Hoadonnhap> n = ncc.GetALLMH();
            Console.Write("Nhap ma hoa don :"); h.Mahdn = Console.ReadLine(); int i;
            for (i = 0; i < n.Count; i++)
                if (n[i].Mahdn == h.Mahdn) break;
            if (i < n.Count)
            {
            }
            else
            {
                Console.WriteLine("Ma hoa don k ton tai");
            }
            do
            {
                Console.Write("Nhap thong tin mat hang can tim kiem: "); string tt = Console.ReadLine();

                for (i = 0; i < list.Count; i++)
                    if (list[i].Mamh == tt || list[i].Tenmh == tt || list[i].Theloai == tt) break;
                if (i < list.Count)
                {
                    Mathang hh = new Mathang(list[i]);
                    List<Mathang> grt = mhbll.Timkiemmathang(hh);
                    bl.themChitiethoadonnhap(grt, h);
                    Console.Write("Nhap so luong:"); h.Soluong = int.Parse(Console.ReadLine());
                }
                else Console.WriteLine("Thong tin mat hang  nay k ton tai");
                Console.WriteLine("Ban co muon nhap tiep c/k");
                ConsoleKeyInfo k2 = Console.ReadKey();
                if (k2.KeyChar == 'K' || k2.KeyChar == 'k')
                {
                    break;
                }
            } while (true);
        }
        public int Tonghd()
        {
            
            List<Chitiethoadonnhap> list = bl.GetALLMH();
            int t = 0;
            foreach (var x in list)
            {
                t += x.Thanhtien;
            }
            return t;
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("THONG TIN CHI TIET HOA DON NHAP");
            List<Chitiethoadonnhap> list = bl.GetALLMH();
            foreach (var x in list)

                Console.WriteLine(x.Mahdn+"\t" + x.Mamh + "\t" + x.Tenmh + "\t" + x.Theloai + "\t" + x.Dongia + "\t" + x.Soluong+"\t"+x.Thanhtien);
            Console.WriteLine("Tong hoa don: " + Tonghd());

        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("Sua so luong mat hang");
            List<Chitiethoadonnhap> list = bl.GetALLMH();
            string mamathang;
            Console.Write("Nhap ma mat hang can sua:"); mamathang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Mamh == mamathang) break;

            if (i < list.Count)
            {
                Console.WriteLine(list[i].Mahdn+"\t" + list[i].Mamh + "\t" + list[i].Tenmh + "\t" + list[i].Theloai + "\t" + list[i].Dongia + "\t" + list[i].Soluong + "\t" + list[i].Thanhtien);
                Chitiethoadonnhap mh = new Chitiethoadonnhap(list[i]);
                mh.Mamh = list[i].Mamh;
                 mh.Tenmh =list[i].Tenmh;
                 mh.Theloai = list[i].Theloai;
                mh.Dongia = list[i].Dongia;
                Console.Write("Nhap so luong moi:"); int soluong = int.Parse(Console.ReadLine());
                if (soluong > 0) mh.Soluong = soluong;
                bl.SuaChitiethoadonnhap(mh);
            }
            else Console.WriteLine("Mat hang nay k ton tai");
        }
        public void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Xoa thong tin hoa don chi tiet");
            List<Chitiethoadonnhap> list = bl.GetALLMH();
            Console.Write("Nhap ma hoa don chi tiet can xoa:"); string mamh = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mamh == mamh) break;
            if (i < list.Count)
            {
               bl.XoaChitiethoadonnhap(mamh);

            }
            else Console.WriteLine("Ma mat hang nay k ton tai");
        }
        
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("        THONG TIN HOA DON CHI TIET     ");
                Console.WriteLine("F1. Nhap hoa don chi tiet ");
                Console.WriteLine("F2. Sua hoa don chi tiet ");
                Console.WriteLine("F3. Xoa hoa don chi tiet ");
                Console.WriteLine("F4. Hien thi hoa don chi tiet ");
                Console.WriteLine("F5. Thoat.... ");
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
                    
                    case ConsoleKey.F4:
                        Hien();
                        Console.WriteLine("Nhan de tiep tuc ......"); Console.ReadKey(); break;
                    case ConsoleKey.F5:
                        Program.Menu1();
                        break;
                
            }
                } while (true) ;

            
            }
    }
}

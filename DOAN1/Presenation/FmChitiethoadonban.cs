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
    public class FmChitiethoadonban    {
        public IChitiethoadonbanBLL bl = new ChitiethoadonbanBLL();
        private IMathangBLL mhbll = new MathangBLL();
        public void Nhap()
        {
            
            Chitiethoadonban h = new Chitiethoadonban();
            Console.Write("Nhập mã hóa đơn:"); h.Mahdb = Console.ReadLine();
            IHoadonbanBLL ncc = new HoadonbanBLL();
            List<Hoadonban> n = ncc.GetALLMH();
            int i;
            for (i = 0; i < n.Count; i++)
                if (n[i].Mahdb == h.Mahdb) break;
            if (i < n.Count)
            {
            }
            else
            {
                Console.WriteLine("Mã hóa đơn không tồn tại");
                
            }
            do
            {
                List<Mathang> list = mhbll.GetALLMH();
                
                Console.Write("Nhập thông tin mặt hàng cần tìm kiếm: "); string tt = Console.ReadLine();
                for (i = 0; i < list.Count; i++)
                    if (list[i].Mamh == tt || list[i].Tenmh == tt || list[i].Theloai == tt) break;
                if (i < list.Count)
                {
                    Mathang hh = new Mathang(list[i]);
                    List<Mathang> grt = mhbll.Timkiemmathang(hh);
                    bl.themChitiethoadonban(grt, h);
                }
                else Console.WriteLine("Thong tin mat hang  nay k ton tai");
                Console.Write("Nhập số lượng:"); h.Soluong = int.Parse(Console.ReadLine());
                Console.Write("Nhap số tiền khuyến  mãi:"); h.KM = int.Parse(Console.ReadLine());
                Console.WriteLine("Bạn có muốn nhập tiếp c/k");
                ConsoleKeyInfo k2 = Console.ReadKey();
                if (k2.KeyChar == 'K' || k2.KeyChar == 'k')
                {
                    break;
                }
            } while (true);

        }
        public int Tonghd()
        {

            List<Chitiethoadonban> list = bl.GetALLMH();
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
            List<Chitiethoadonban> list = bl.GetALLMH();
            foreach (var x in list)

                Console.WriteLine(x.Mahdb + "\t" + x.Mamh + "\t" + x.Tenmh + "\t" + x.Theloai + "\t" + x.Dongia + "\t" + x.Soluong + "\t" +x.KM + "\t" + x.Thanhtien);
            Console.WriteLine("Tong hoa don: " + Tonghd());

        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("Sua so luong mat hang");
            List<Chitiethoadonban> list = bl.GetALLMH();
            string mamathang;
            Console.Write("Nhap ma mat hang can sua:"); mamathang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Mamh == mamathang) break;

            if (i < list.Count)
            {
                Console.WriteLine(list[i].Mahdb + "\t" + list[i].Mamh + "\t" + list[i].Tenmh + "\t" + list[i].Theloai + "\t" + list[i].Dongia + "\t" + list[i].Soluong + "\t" +list[i].KM + "\t" + list[i].Thanhtien);
                Chitiethoadonban mh = new Chitiethoadonban(list[i]);
                mh.Mamh = list[i].Mamh;
                mh.Tenmh = list[i].Tenmh;
                mh.Theloai = list[i].Theloai;
                mh.Dongia = list[i].Dongia;
                Console.Write("Nhap so luong moi:"); int soluong = int.Parse(Console.ReadLine());
                if (soluong > 0) mh.Soluong = soluong;
                Console.Write("Nhap km moi:"); int km = int.Parse(Console.ReadLine());
                if (km > 0) mh.KM = km;
                bl.SuaChitiethoadonban(mh);
            }
            else Console.WriteLine("Mat hang nay k ton tai");
        }
        public void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Xoa thong tin hoa don chi tiet");
            List<Chitiethoadonban> list = bl.GetALLMH();
            Console.Write("Nhap ma hoa don chi tiet can xoa:"); string mamh = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mamh == mamh) break;
            if (i < list.Count)
            {
                bl.XoaChitiethoadonban(mamh);

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
            } while (true);


        }
    }
}

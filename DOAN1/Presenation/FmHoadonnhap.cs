using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.BusinessLayer;
using DOAN1.Entities;
namespace DOAN1.Presenation
{
    public class FmHoadonnhap
    {
        private IHoadonnhapBLL hdnbll = new HoadonnhapBLL();

        public  void Nhap()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("THONG TIN HOA DON NHAP");
                Hoadonnhap hd = new Hoadonnhap();
                Console.Write("Nhap ma hoa don:"); hd.Mahdn = Console.ReadLine();
                Console.Write("Nhap ten hoa don:"); hd.Tenhdn = Console.ReadLine();
                INhacungcapBLL ncc = new NhacungcapBLL();
                List<Nhacungcap> n = ncc.GetALLMH();
                Console.Write("Nhap ma nha cung cap :"); hd.Mancc = Console.ReadLine(); int i;
                for (i = 0; i < n.Count; i++)
                    if (n[i].Mancc == hd.Mancc) break;
                if (i < n.Count)
                {
                }
                else
                {
                    Console.WriteLine("Ma nha cung cap k ton tai");  break;

                }
                Console.Write("Nhap ten nhan vien giao:"); hd.Tennvg = Console.ReadLine();
                INhanvienBLL nv = new NhanvienBLL();
                List<Nhanvien> nv1 = nv.GetALLMH();
                Console.Write("Nhap ma nhan vien :"); hd.Manv = Console.ReadLine();
                for (i = 0; i < nv1.Count; i++)
                    if (nv1[i].Manv == hd.Manv) break;
                if (i < nv1.Count)
                {
                }
                else
                {
                    Console.WriteLine("Ten nhan vien khong ton tai"); break;
                }
                hd.Ngaynhan = DateTime.Now;
                Console.Write("Nhap so tien no:"); hd.No = int.Parse(Console.ReadLine());
                Console.Write("Ghi chu:"); hd.Ghichu = Console.ReadLine();
                hdnbll.themHoadonnhap(hd);
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
            Console.WriteLine("THONG TIN HOA DON NHAP");
            List<Hoadonnhap> list = hdnbll.GetALLMH();
            foreach (var x in list)
                
                Console.WriteLine(x.Mahdn+ "\t" + x.Tenhdn + "\t" + x.Mancc + "\t" + x.Tennvg+"\t"+x.Manv+"\t"+x.Ngaynhan+"\t"+x.No+"\t"+x.Ghichu);

        }
        public void Sua()
        {
           // Console.Clear();
            Console.WriteLine("Sua thong tin hoa don nhap");
            List<Hoadonnhap> list = hdnbll.GetALLMH();
            string mahoadon;
            Console.Write("Nhap ma hoa don can sua:"); mahoadon = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)

                if (list[i].Mahdn== mahoadon) break;

            if (i < list.Count)
            {
              //Console.WriteLine(list[i].Mahdn + "\t" + list[i].Tenhdn + "\t" + list[i].Mancc + "\t" + list[i].Tennvg + "\t" + list[i].Tennv + "\t" + list[i].Ngaynhan + "\t" +list[i].No + "\t" + list[i].Ghichu);

                Hoadonnhap kh = new Hoadonnhap(list[i]);
                Console.Write("Nhap ten moi:"); string ten = Console.ReadLine();
                if (ten != kh.Tenhdn) kh.Tenhdn = ten;
                Console.Write("Nhap ma nha cung cap moi:"); string ncc = Console.ReadLine();
                if (ncc != kh.Mancc) kh.Mancc = ncc;
                Console.Write("Nhap ten nhan vien giao moi:"); string tennvg = Console.ReadLine();
                if (tennvg != kh.Tennvg) kh.Tennvg = tennvg;
                Console.Write("Nhap ma nhan vien nhan moi:"); string tenvn = Console.ReadLine();
                if (tenvn != kh.Manv) kh.Manv = tenvn;
                kh.Ngaynhan = DateTime.Now;
                Console.Write("Nhap No moi:"); int no =int.Parse( Console.ReadLine());
                if (no !=kh.No) kh.No = no;
                Console.Write("Nhap Ghi chu:"); string gc = Console.ReadLine();
                if (gc != kh.Ghichu) kh.Ghichu = gc;
                hdnbll.SuaHoadonnhap(kh);
            }
            else Console.WriteLine("Hoa don nay k ton tai");
        }
        public void Xoa()
        {
            //Console.Clear();

            List<Hoadonnhap> list = hdnbll.GetALLMH();
            Console.Write("Nhap ma hoa don nhap can xoa:"); string mahn = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Mahdn == mahn) break;
            if (i < list.Count)
            {
                hdnbll.XoaHoadonnhap(mahn);

            }
            else Console.WriteLine("Hoa don nay k ton tai");
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Tim kiem hoa don nhap theo ten hoa don , ma nha cung cap ten nhan vien va ma hoa don");
            List<Hoadonnhap> list = hdnbll.GetALLMH();

            Console.WriteLine("Nhap thong tin hoa don can tim kiem"); string tt = Console.ReadLine();
            int i = 0;
            
                for (i = 0; i < list.Count; i++)

                    if (list[i].Mahdn == tt || list[i].Tenhdn == tt || list[i].Mancc == tt || list[i].Manv == tt) break;
                if (i < list.Count)
                {
                    List<Hoadonnhap> grt = hdnbll.TimkiemHoadonnhap(new Hoadonnhap(list[i]));
                    foreach (var x in grt)

                        Console.WriteLine(x.Mahdn + "\t" + x.Tenhdn + "\t" + x.Mancc + "\t" + x.Tennvg + "\t" + x.Manv + "\t" + x.Ngaynhan + "\t" + x.No + "\t" + x.Ghichu);
                }

                else Console.WriteLine("Thong tin hoa don nay k ton tai");
        }
        public void Chitiethoadon()
        {
            IChitiethoadonnhapBLL ht = new ChitiethoadonnhapBLL();
            List<Hoadonnhap> list = hdnbll.GetALLMH();
            List<Chitiethoadonnhap> list1 = ht.GetALLMH();
            Console.WriteLine("Nhap ma hoa don can xem chi tiet: "); string mahd = Console.ReadLine();
            for(int i = 0; i < list.Count; i++)
            { 
                    if (list[i].Mahdn == mahd)
                    {
                        Console.WriteLine(list[i].Mahdn + "\t" + list[i].Tenhdn + "\t" + list[i].Mancc + "\t" + list[i].Tennvg + "\t" + list[i].Manv + "\t" + list[i].Ngaynhan + "\t" + list[i].No + "\t" + list[i].Ghichu);
                        
                    }
             }
            for(int j = 0; j < list1.Count; j++)
            {
                if (list[j].Mahdn == mahd)
                {
                    Console.WriteLine(list1[j].Mahdn + "\t" + list1[j].Mamh + "\t" + list1[j].Tenmh + "\t" + list1[j].Theloai + "\t" + list1[j].Dongia + "\t" + list1[j].Soluong + "\t" + list1[j].Thanhtien);
                }
            }
        }
        
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("                                   ____________________________________________________________________");
                Console.WriteLine("                                   |                   QUAN LY THONG TIN HOA DON NHAP                 |");
                Console.WriteLine("                                   |          F1.Nhập thông tin hóa đơn nhập                          |");
                Console.WriteLine("                                   |          F2.Sửa thông tin hóa đơn nhập                           |");
                Console.WriteLine("                                   |          F3.Xóa hóa đơn nhập                                     |");
                Console.WriteLine("                                   |          F4.Hiện thị thông tin hóa đơn nhập                      |");
                Console.WriteLine("                                   |          F5.Tìm kiếm hóa đơn nhập                                |");
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

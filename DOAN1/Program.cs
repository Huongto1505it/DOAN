using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Presenation;
namespace DOAN1
{
    public class Program
    {
        
        public static void Menu1()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("QUAN LI BAN SACH");
                Console.WriteLine("F1: Quan li mat hang");
                Console.WriteLine("F2: Quan li khach hang");
                Console.WriteLine("F3: Quan li nhan vien");
                Console.WriteLine("F4: Quan li nha cung cap");
                Console.WriteLine("F5: Quan li hoa don nhap");
                Console.WriteLine("F6: Quan li chi tiet hoa don nhap");
                Console.WriteLine("F7: Quan li hoa don ban");
                Console.WriteLine("F8: Quan li chi tiet hoa don ban");
                
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        FmMathang fmmh = new FmMathang();
                        fmmh.Menu(); break;
                    case ConsoleKey.F2:
                        FmKhachhang fmkh = new FmKhachhang();
                        fmkh.Menu(); break;
                    case ConsoleKey.F3:
                        FmNhanvien fmnv = new FmNhanvien();
                        fmnv.Menu(); break;
                    case ConsoleKey.F4:
                        FmNhacungcap fmncc = new FmNhacungcap();
                        fmncc.Menu(); break;
                    case ConsoleKey.F5:
                        FmHoadonnhap fmhdn = new FmHoadonnhap();
                        fmhdn.Menu(); break;
                    case ConsoleKey.F6:
                        FmChitiethoadonnhap fmhdnct = new FmChitiethoadonnhap();
                        fmhdnct.Menu(); break;
                    case ConsoleKey.F7:
                        FmHoadonban fmhdb = new FmHoadonban();
                        fmhdb.Menu(); break;
                    case ConsoleKey.F8:
                        FmChitiethoadonban fmhb = new FmChitiethoadonban();
                        fmhb.Menu(); break;
                    //case ConsoleKey.F9:
                        //Thongke tk = new Thongke();
                        //tk.Menu(); break;
                }
            } while (true);
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu1();
        }
    }
}

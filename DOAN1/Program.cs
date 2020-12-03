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
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        FmMathang fm = new FmMathang();
                        fm.Menu(); break;
                    case ConsoleKey.F2:
                        FmKhachhang fm1 = new FmKhachhang();
                        fm1.Menu(); break;
                }
            } while (true);
        }
        public static void Main(string[] args)
        {
            Menu1();
        }
    }
}

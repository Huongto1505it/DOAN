using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class MathangDAL : IMathangDAL
    {
        private string tex = "Data/mathang.txt";
        public List<Mathang> GetAllMathang()
        {
            List<Mathang> list = new List<Mathang>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Mathang(a[0], a[1], a[2], int.Parse(a[3])));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemMathang(Mathang mh)
        {
            string mamhang = "Sp" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            sw.Write(mamhang + "#" + mh.Tenmh + "#" + mh.Theloai + "#" + mh.Dongia);
            sw.Close();
        }
        public void CapnhatMathang(List<Mathang> MH)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < MH.Count; i++)
                sw.WriteLine(MH[i].Mamh + "#" + MH[i].Tenmh + "#" + MH[i].Theloai + "#" + MH[i].Dongia);
            sw.Close();
        }

    }
}

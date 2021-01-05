using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class ChitiethoadonnhapDAL : IChitiethoadonnhapDAL        
    {
        private string tex = "Data/Chitiethoadonnhap.txt";
        public List<Chitiethoadonnhap> GetAllChitiethoadonnhap()
        {
            List<Chitiethoadonnhap> list = new List<Chitiethoadonnhap>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Chitiethoadonnhap(a[0],a[1], a[2], a[3], int.Parse(a[4]),int.Parse(a[5])));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemChitiethoadonnhap(List<Mathang> h, Chitiethoadonnhap mh)
        {

            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            for (int i = 0; i <h.Count; i++)
                sw.Write(mh.Mahdn+"#" + h[i].Mamh + "#" + h[i].Tenmh + "#" + h[i].Theloai + "#" + h[i].Dongia+"#"+mh.Soluong);
            sw.Close();
        }
        public void CapnhatChitiethoadonnhap(List<Chitiethoadonnhap> MH)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < MH.Count; i++)
                sw.WriteLine(MH[i].Mahdn+"#" + MH[i].Mamh + "#" + MH[i].Tenmh + "#" + MH[i].Theloai + "#" + MH[i].Dongia + "#" + MH[i].Soluong);
            sw.Close();
        }

    }
}

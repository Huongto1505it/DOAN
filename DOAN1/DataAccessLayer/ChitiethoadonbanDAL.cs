using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class ChitiethoadonbanDAL : IChitiethoadonbanDAL
    {
        private string tex = "Data/Chitiethoadonban.txt";
        public List<Chitiethoadonban> GetAllChitiethoadonban()
        {
            List<Chitiethoadonban> list = new List<Chitiethoadonban>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Chitiethoadonban(a[0], a[1], a[2], a[3], int.Parse(a[4]), int.Parse(a[5]), int.Parse(a[6])));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemChitiethoadonban(List<Mathang> h, Chitiethoadonban mh)
        {

            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            for (int i = 0; i < h.Count; i++)
                sw.Write(mh.Mahdb + "#" + h[i].Mamh + "#" + h[i].Tenmh + "#" + h[i].Theloai + "#" + h[i].Dongia + "#" + mh.Soluong +"#" + mh.KM);
            sw.Close();
        }
        public void CapnhatChitiethoadonban(List<Chitiethoadonban> MH)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < MH.Count; i++)
                sw.WriteLine(MH[i].Mahdb + "#" + MH[i].Mamh + "#" + MH[i].Tenmh + "#" + MH[i].Theloai + "#" + MH[i].Dongia + "#" + MH[i].Soluong +"#" + MH[i].KM);
            sw.Close();
        }

    }
}

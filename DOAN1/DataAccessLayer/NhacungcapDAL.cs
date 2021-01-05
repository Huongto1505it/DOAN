using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class NhacungcapDAL : INhacungcapDAL
    {
        private string tex = "Data/Nhacungcap.txt";
        public List<Nhacungcap> GetAllNhacungcap()
        {
            List<Nhacungcap> list = new List<Nhacungcap>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Nhacungcap(a[0], a[1], a[2], a[3]));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemNhacungcap(Nhacungcap ncc)
        {

            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            sw.Write(ncc.Mancc + "#" + ncc.Tenncc + "#" + ncc.Diachi + "#" + ncc.SDT);
            sw.Close();
        }
        public void CapnhatNhacungcap(List<Nhacungcap> ncc)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < ncc.Count; i++)
                sw.WriteLine(ncc[i].Mancc + "#" + ncc[i].Tenncc + "#" + ncc[i].Diachi + "#" + ncc[i].SDT);
            sw.Close();
        }

    }
}

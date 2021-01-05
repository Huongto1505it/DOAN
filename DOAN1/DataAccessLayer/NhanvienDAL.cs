using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class NhanvienDAL : INhanvienDAL
    {
        private string tex = "Data/Nhanvien.txt";
        public List<Nhanvien> GetAllNhanvien()
        {
            List<Nhanvien> list = new List<Nhanvien>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Nhanvien(a[0], a[1], a[2], a[3]));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemNhanvien(Nhanvien nv)
        {
            
            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            sw.Write(nv.Manv + "#" + nv.Tennv + "#" + nv.Diachi + "#" + nv.SDT);
            sw.Close();
        }
        public void CapnhatNhanvien(List<Nhanvien> nv)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < nv.Count; i++)
                sw.WriteLine(nv[i].Manv + "#" + nv[i].Tennv + "#" + nv[i].Diachi + "#" + nv[i].SDT);
            sw.Close();
        }

    }
}

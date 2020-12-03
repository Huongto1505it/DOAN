using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class KhachhangDAL : IKhachhangDAL
    {
        private string tex = "Data/khachhang.txt";
        public List<Khachhang> GetAllKhachhang()
        {
            List<Khachhang> list = new List<Khachhang>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Khachhang(a[0], a[1], a[2], a[3]));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void Themkhachhang(Khachhang mh)
        {
            string mamhang = "Sp" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            sw.Write(mamhang + "#" + mh.Tenkh + "#" + mh.Diachi + "#" + mh.SDT);
            sw.Close();
        }
        public void Capnhatkhachhang(List<Khachhang> MH)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < MH.Count; i++)
                sw.WriteLine(MH[i].Makh + "#" + MH[i].Tenkh + "#" + MH[i].Diachi + "#" + MH[i].SDT);
            sw.Close();
        }

    }
}

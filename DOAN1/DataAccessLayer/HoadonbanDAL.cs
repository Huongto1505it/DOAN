using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class HoadonbanDAL : IHoadonbanDAL
    {
        private string tex = "Data/Hoadonban.txt";
        public List<Hoadonban> GetAllHoadonban()
        {
            List<Hoadonban> list = new List<Hoadonban>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Hoadonban(a[0], a[1], a[2], a[3], DateTime.Parse(a[4])));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemHoadonban(Hoadonban hd)
        {

            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            sw.Write(hd.Mahdb + "#" + hd.Manv + "#" + hd.Makh + "#" + hd.Ghichu + "#" + hd.Ngayban );
            sw.Close();
        }
        public void CapnhatHoadonban(List<Hoadonban> hd)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < hd.Count; i++)
                sw.WriteLine(hd[i].Mahdb + "#" + hd[i].Manv + "#" + hd[i].Makh + "#" + hd[i].Ghichu + "#" + hd[i].Ngayban );
            sw.Close();
        }

    }
}

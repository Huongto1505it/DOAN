using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public class HoadonnhapDAL : IHoadonnhapDAL
    {
        private string tex = "Data/Hoadonnhap.txt";
        public List<Hoadonnhap> GetAllHoadonnhap()
        {
            List<Hoadonnhap> list = new List<Hoadonnhap>();
            StreamReader sr = File.OpenText(tex);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Hoadonnhap(a[0], a[1], a[2], a[3], a[4], DateTime.Parse(a[5]), int.Parse(a[6]), a[7]));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void ThemHoadonnhap(Hoadonnhap hd)
        {

            StreamWriter sw = File.AppendText(tex);
            sw.WriteLine();
            sw.Write(hd.Mahdn + "#" + hd.Tenhdn + "#" + hd.Mancc + "#" + hd.Tennvg+"#"+hd.Manv+"#"+hd.Ngaynhan+"#"+hd.No+"#"+hd.Ghichu);
            sw.Close();
        }
        public void CapnhatHoadonnhap(List<Hoadonnhap> hd)
        {
            StreamWriter sw = File.CreateText(tex);
            for (int i = 0; i < hd.Count; i++)
                sw.WriteLine(hd[i].Mahdn+ "#"  + hd[i].Tenhdn +"#"+ hd[i].Mancc + "#" + hd[i].Tennvg + "#" + hd[i].Manv + "#" + hd[i].Ngaynhan + "#" + hd[i].No + "#" + hd[i].Ghichu);
            sw.Close();
        }

    }
}

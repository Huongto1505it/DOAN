using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
   public class Chitiethoadonnhap: Mathang
    {
        private string mahdn;
        private int soluong;
        public string Mahdn
        {
            get { return mahdn; }
            set { if (!string.IsNullOrEmpty(value)) mahdn = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { if (value > 0)  soluong=value; }
        }
        public int Thanhtien
        {
            get { return dongia * soluong; }
        }
        public Chitiethoadonnhap():base(){  }
          public Chitiethoadonnhap(string mahdn,string mamh, string tenmh, string theloai, int dongia,int soluong) : base(mamh, tenmh, theloai, dongia)
        {
            this.mahdn = mahdn;
            this.soluong = soluong;
        }       
        public Chitiethoadonnhap(Chitiethoadonnhap t2)
        {
            this.mahdn =t2. mahdn;
            this.soluong = t2.soluong;
        }
    }
}

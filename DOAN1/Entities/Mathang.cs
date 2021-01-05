using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    public class Mathang
    {
        private string mamh, tenmh, theloai;
        protected int dongia;
        public string Mamh
        {
            get { return mamh; }
            set { if (!string.IsNullOrEmpty(value)) mamh = value; }
        }
        public string Tenmh
        {
            get { return tenmh; }
            set { if (!string.IsNullOrEmpty(value)) tenmh = value; }
        }
        public string Theloai
        {
            get { return theloai; }
            set { if (!string.IsNullOrEmpty(value)) theloai = value; }
        }
        public int Dongia
        {
            get { return dongia; }
            set { if (value >= 0) dongia = value; }
        }
        public Mathang() { }
        public Mathang(string mamh, string tenmh, string theloai, int dongia)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.theloai = theloai;
            this.dongia = dongia;
        }
        public Mathang(Mathang t2)
        {     
            this.mamh = t2.mamh;
            this.tenmh = t2.tenmh;
            this.theloai = t2.theloai;
            this.dongia = t2.dongia;
        }



    }
}

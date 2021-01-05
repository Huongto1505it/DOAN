using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    public class Chitiethoadonban : Mathang
    {
        private string mahdb;
        private int soluong;
        private int km;
        public string Mahdb
        {
            get { return mahdb; }
            set { if (!string.IsNullOrEmpty(value)) mahdb = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { if (value > 0) soluong = value; }
        }
        public int KM
        {
            get { return km; }
            set { if (value > 0) km = value; }
        }
        public int Thanhtien
        {
            get { return dongia * soluong-km; }
        }
        public Chitiethoadonban() : base() { }
        public Chitiethoadonban(string mahdb, string mamh, string tenmh, string theloai, int dongia, int soluong,int km) : base(mamh, tenmh, theloai, dongia)
        {
            this.mahdb = mahdb;
            this.soluong = soluong;
            this.km = km;
        }
        public Chitiethoadonban(Chitiethoadonban t2)
        {
            this.mahdb = t2.mahdb;
            this.soluong = t2.soluong;
            this.km =t2. km;
        }
    }
}

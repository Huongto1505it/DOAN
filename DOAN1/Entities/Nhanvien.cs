using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    public class Nhanvien
    {
        protected string manv, tennv, diachi;
        protected string sdt;
        public string Manv
        {
            get { return manv; }
            set { if (!string.IsNullOrEmpty(value)) manv = value; }
        }
        public string Tennv
        {
            get { return tennv; }
            set { if (!string.IsNullOrEmpty(value)) tennv = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { if (!string.IsNullOrEmpty(value)) diachi = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { if (!string.IsNullOrEmpty(value) && value.Length == 10) sdt = value; }
        }
        public Nhanvien() { }
        public Nhanvien(string manv, string tennv, string diachi, string sdt)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public Nhanvien(Nhanvien t2)
        {
            this.manv = t2.manv;
            this.tennv = t2.tennv;
            this.diachi = t2.diachi;
            this.sdt = t2.sdt;
        }


    }
}

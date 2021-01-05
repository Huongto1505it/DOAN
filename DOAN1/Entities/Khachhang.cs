using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
   public class Khachhang
    {
        protected string makh, tenkh, diachi;
        protected string sdt;
        public string Makh
        {
            get { return makh; }
            set { if (!string.IsNullOrEmpty(value) ) makh = value; }
        }
        public string Tenkh
        {
            get { return tenkh; }
            set { if (!string.IsNullOrEmpty(value)) tenkh = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { if (!string.IsNullOrEmpty(value)) diachi = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { if (!string.IsNullOrEmpty(value) && value.Length==10) sdt = value; }
        }
        public Khachhang() { }
        public Khachhang(string makh, string tenkh, string diachi, string sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public Khachhang(Khachhang t2)
        {
            this.makh = t2.makh;
            this.tenkh = t2.tenkh;
            this.diachi = t2.diachi;
            this.sdt = t2.sdt;
        }


    }
}

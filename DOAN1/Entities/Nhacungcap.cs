using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    public class Nhacungcap
    {
        protected string mancc, tenncc, diachi;
        protected string sdt;
        public string Mancc
        {
            get { return mancc; }
            set { if (!string.IsNullOrEmpty(value)) mancc = value; }
        }
        public string Tenncc
        {
            get { return tenncc; }
            set { if (!string.IsNullOrEmpty(value)) tenncc = value; }
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
        public Nhacungcap() { }
        public Nhacungcap(string mancc, string tenncc, string diachi, string sdt)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public Nhacungcap(Nhacungcap t2)
        {
            this.mancc = t2.mancc;
            this.tenncc = t2.tenncc;
            this.diachi = t2.diachi;
            this.sdt = t2.sdt;
        }


    }
}

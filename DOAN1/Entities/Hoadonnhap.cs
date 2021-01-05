using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
   public class Hoadonnhap { 
        protected string mahdn, tenhdn, tennvg, ghichu;
        protected string mancc;
        protected string manv;
        protected int no;
        protected DateTime ngaynhan;
        public string Mahdn
        {
            get { return mahdn; }
            set { if (!string.IsNullOrEmpty(value)) mahdn = value; }
        }
        public string Tenhdn
        {
            get { return tenhdn; }
            set { if (!string.IsNullOrEmpty(value)) tenhdn = value; }
        }
        public string Tennvg
        {
            get { return tennvg; }
            set { if (!string.IsNullOrEmpty(value)) tennvg = value; }
        }
        public string Ghichu
        {
            get { return ghichu; }
            set { if (!string.IsNullOrEmpty(value)) ghichu = value; }
        }
        public string Mancc
        {
            get { return mancc; }
            set { if (!string.IsNullOrEmpty(value)) mancc = value; }
        }
        public string Manv
        {
            get { return manv; }
            set { if (!string.IsNullOrEmpty(value)) manv = value; }
        }
        public DateTime Ngaynhan
        {
            get { return ngaynhan; }
            set { ngaynhan = value; }
        }
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public Hoadonnhap() { }
        public Hoadonnhap(string mahdn,string tenhdn,string mancc,string tennvg, string tennv,DateTime ngaynhan,int no, string ghichu) { 
            this.mahdn = mahdn;
            this.tenhdn = tenhdn;
            this.mancc = mancc;
            this.tennvg = tennvg;
            this.manv = tennv;
            
            this.ngaynhan = ngaynhan;
            this.no = no;
            this.ghichu = ghichu;
           
            this.manv = tennv;
        }
        public Hoadonnhap(Hoadonnhap t2)
        {
            this.mahdn =t2. mahdn;
            this.tenhdn =t2. tenhdn;
            this.tennvg =t2. tennvg;
            this.ghichu =t2. ghichu;
            this.ngaynhan =t2. ngaynhan;
            this.no =t2. no;
            this.mancc =t2. mancc;
            this.manv = t2.manv;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
   public class Hoadonban
    {
        private string mahdb, manv, makh,ghichu;
        private DateTime ngayban;
        public string Mahdb
        {
            get { return mahdb; }
            set { if (value != " ") mahdb=value; }
        }
        public string Manv 
        {
            get { return manv; }
            set { if (value != " ") manv = value; }
        }
        public string Makh
        {
            get { return makh; }
            set { if (value != " ") makh = value; }
        }
        public string Ghichu
        {
            get { return ghichu; }
            set { if (value != " ") ghichu = value; }
        }
        public DateTime Ngayban
        {
            get { return ngayban; }
            set { ngayban = value; }
        }
        public Hoadonban() { }
        public Hoadonban(string mahdb,string manv, string makh,string ghichu,DateTime ngayban)
        {
            this.mahdb = mahdb;
            this.manv = manv;
            this.makh = makh;
            this.ghichu = ghichu;
            this.ngayban = ngayban;
        }
        public Hoadonban(Hoadonban t2)
        {
            this.mahdb =t2. mahdb;
            this.manv = t2.manv;
            this.makh = t2.makh;
            this.ghichu =t2. ghichu;
            this.ngayban =t2. ngayban;
        }
    }
}

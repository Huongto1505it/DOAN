using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class KhachhangBLL : IKhachhangBLL
    {
        private IKhachhangDAL mhdal = new KhachhangDAL();
        public List<Khachhang> GetALLMH()
        {
            return mhdal.GetAllKhachhang();
        }
        public void themkhachhang(Khachhang kh)
        {
            if (kh.Tenkh != "")
            {
                mhdal.Themkhachhang(kh);
            }
            else Console.WriteLine("Du lieu sai");
        }
        public void Suakhachhang(Khachhang kh)
        {
            int i;
            List<Khachhang> khlist = mhdal.GetAllKhachhang();
            for (i = 0; i < khlist.Count; i++)
                if (khlist[i].Makh == kh.Makh) break;

            if (i < khlist.Count)
            {
                khlist.RemoveAt(i);
                khlist.Add(kh);
                mhdal.Capnhatkhachhang(khlist);
            }
            else
                throw new Exception("Khong ton tai khach hang nay");
        }
        public void Xoakhachhang(string Makh)
        {
            int i;
            List<Khachhang> khlist = mhdal.GetAllKhachhang();
            for (i = 0; i < khlist.Count; i++)
            {
                if (khlist[i].Makh == Makh) break;
            }
            if (i < khlist.Count)
            {
                khlist.RemoveAt(i);
                mhdal.Capnhatkhachhang(khlist);
            }
            else
                throw new Exception("Khong ton tai khach hang nay");
        }
        public List<Khachhang> Timkiemkhachhang(Khachhang kh)
        {
            List<Khachhang> list = mhdal.GetAllKhachhang();
            List<Khachhang> MH = new List<Khachhang>();
            if (string.IsNullOrEmpty(kh.Makh) && string.IsNullOrEmpty(kh.Tenkh) && string.IsNullOrEmpty(kh.Diachi))
            {
                MH = list;
            }
            if (!string.IsNullOrEmpty(kh.Makh))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Makh.IndexOf(kh.Makh) >= 0)
                    {
                        MH.Add(new Khachhang(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(kh.Tenkh))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tenkh.IndexOf(kh.Tenkh) >= 0)
                    {
                        MH.Add(new Khachhang(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(kh.Diachi))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Diachi.IndexOf(kh.Diachi) >= 0)
                    {
                        MH.Add(new Khachhang(list[i]));
                    }
                }
            }


            return MH;
        }
    }
}

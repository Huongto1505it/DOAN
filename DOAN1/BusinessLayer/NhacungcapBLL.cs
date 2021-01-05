using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class NhacungcapBLL : INhacungcapBLL
    {
        private INhacungcapDAL mhdal = new NhacungcapDAL();
        public List<Nhacungcap> GetALLMH()
        {
            return mhdal.GetAllNhacungcap();
        }
        public void themNhacungcap(Nhacungcap ncc)
        {
            if (ncc.Tenncc != "")
            {
                mhdal.ThemNhacungcap(ncc);
            }
            else Console.WriteLine("Du lieu sai");
        }
        public void SuaNhacungcap(Nhacungcap ncc)
        {
            int i;
            List<Nhacungcap> khlist = mhdal.GetAllNhacungcap();
            for (i = 0; i < khlist.Count; i++)
                if (khlist[i].Mancc == ncc.Mancc) break;

            if (i < khlist.Count)
            {
                khlist.RemoveAt(i);
                khlist.Add(ncc);
                mhdal.CapnhatNhacungcap(khlist);
            }
            else
                throw new Exception("Khong ton tai nha cung cap nay");
        }
        public void XoaNhacungcap(string Mancc)
        {
            int i;
            List<Nhacungcap> khlist = mhdal.GetAllNhacungcap();
            for (i = 0; i < khlist.Count; i++)
            {
                if (khlist[i].Mancc == Mancc) break;
            }
            if (i < khlist.Count)
            {
                khlist.RemoveAt(i);
                mhdal.CapnhatNhacungcap(khlist);
            }
            else
                throw new Exception("Khong ton tai nha cung cap nay");
        }
        public List<Nhacungcap> TimkiemNhacungcap(Nhacungcap ncc)
        {
            List<Nhacungcap> list = mhdal.GetAllNhacungcap();
            List<Nhacungcap> MH = new List<Nhacungcap>();
            if (string.IsNullOrEmpty(ncc.Mancc) && string.IsNullOrEmpty(ncc.Tenncc) && string.IsNullOrEmpty(ncc.Diachi))
            {
                MH = list;
            }
            if (!string.IsNullOrEmpty(ncc.Mancc))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Mancc.IndexOf(ncc.Mancc) >= 0)
                    {
                        MH.Add(new Nhacungcap(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(ncc.Tenncc))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tenncc.IndexOf(ncc.Tenncc) >= 0)
                    {
                        MH.Add(new Nhacungcap(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(ncc.Diachi))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Diachi.IndexOf(ncc.Diachi) >= 0)
                    {
                        MH.Add(new Nhacungcap(list[i]));
                    }
                }
            }


            return MH;
        }
    }
}

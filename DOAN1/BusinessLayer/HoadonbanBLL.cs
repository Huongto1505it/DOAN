using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class HoadonbanBLL : IHoadonbanBLL
    {
        private IHoadonbanDAL mhdal = new HoadonbanDAL();
        public List<Hoadonban> GetALLMH()
        {
            return mhdal.GetAllHoadonban();
        }
        public void themHoadonban(Hoadonban hdb)
        {
            if (hdb.Mahdb != "")
            {
                mhdal.ThemHoadonban(hdb);
            }
            else throw new Exception("Du lieu sai");
        }
        public void SuaHoadonban(Hoadonban hdb)
        {
            int i;
            List<Hoadonban> MH = mhdal.GetAllHoadonban();
            for (i = 0; i < MH.Count; i++)
                if (MH[i].Mahdb == hdb.Mahdb) break;

            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                MH.Add(hdb);
                mhdal.CapnhatHoadonban(MH);
            }
            else
                throw new Exception("Khong ton tai hoa don nay");
        }
        public void XoaHoadonban(string Mahdb)
        {
            int i;
            List<Hoadonban> MH = mhdal.GetAllHoadonban();
            for (i = 0; i < MH.Count; i++)
            {
                if (MH[i].Mahdb == Mahdb) break;
            }
            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                mhdal.CapnhatHoadonban(MH);
            }
            else
                throw new Exception("Khong ton tai hoa don  nay");
        }
        public List<Hoadonban> TimkiemHoadonban(Hoadonban hdb)
        {
            List<Hoadonban> list = mhdal.GetAllHoadonban();
            List<Hoadonban> MH = new List<Hoadonban>();
            if (string.IsNullOrEmpty(hdb.Mahdb) && string.IsNullOrEmpty(hdb.Makh) )
            {
                MH = list;
            }
            if (!string.IsNullOrEmpty(hdb.Mahdb))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Mahdb.IndexOf(hdb.Mahdb) >= 0)
                    {
                        MH.Add(new Hoadonban(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(hdb.Makh))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Makh.IndexOf(hdb.Makh) >= 0)
                    {
                        MH.Add(new Hoadonban(list[i]));
                    }
                }
            }
           
            return MH;
        }
    }
}

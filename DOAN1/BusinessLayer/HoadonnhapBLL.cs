using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class HoadonnhapBLL : IHoadonnhapBLL
    {
        private IHoadonnhapDAL mhdal = new HoadonnhapDAL();
        public List<Hoadonnhap> GetALLMH()
        {
            return mhdal.GetAllHoadonnhap();
        }
        public void themHoadonnhap(Hoadonnhap hdn)
        {
            if (hdn.Mahdn != "")
            {
                mhdal.ThemHoadonnhap(hdn);
            }
            else throw new Exception("Du lieu sai");
        }
        public void SuaHoadonnhap(Hoadonnhap hdn)
        {
            int i;
            List<Hoadonnhap> MH = mhdal.GetAllHoadonnhap();
            for (i = 0; i < MH.Count; i++)
                if (MH[i].Mahdn == hdn.Mahdn) break;

            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                MH.Add(hdn);
                mhdal.CapnhatHoadonnhap(MH);
            }
            else
                throw new Exception("Khong ton tai hoa don nay");
        }
        public void XoaHoadonnhap(string Mahdn)
        {
            int i;
            List<Hoadonnhap> MH = mhdal.GetAllHoadonnhap();
            for (i = 0; i < MH.Count; i++)
            {
                if (MH[i].Mahdn == Mahdn) break;
            }
            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                mhdal.CapnhatHoadonnhap(MH);
            }
            else
                throw new Exception("Khong ton tai hoa don  nay");
        }
        public List<Hoadonnhap> TimkiemHoadonnhap(Hoadonnhap hdn)
        {
            List<Hoadonnhap> list = mhdal.GetAllHoadonnhap();
            List<Hoadonnhap> MH = new List<Hoadonnhap>();
            if (string.IsNullOrEmpty(hdn.Mahdn) && string.IsNullOrEmpty(hdn.Tenhdn)  && string.IsNullOrEmpty(hdn.Mancc) && string.IsNullOrEmpty(hdn.Manv))
            {
                MH = list;
            }
            if (!string.IsNullOrEmpty(hdn.Mahdn))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Mahdn.IndexOf(hdn.Mahdn) >= 0)
                    {
                        MH.Add(new Hoadonnhap(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(hdn.Tenhdn))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tenhdn.IndexOf(hdn.Tenhdn) >= 0)
                    {
                        MH.Add(new Hoadonnhap(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(hdn.Mancc))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Mancc.IndexOf(hdn.Mancc) >= 0)
                    {
                        MH.Add(new Hoadonnhap(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(hdn.Manv))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Manv.IndexOf(hdn.Manv) >= 0)
                    {
                        MH.Add(new Hoadonnhap(list[i]));
                    }
                }
            }
            return MH;
        }
    }
}

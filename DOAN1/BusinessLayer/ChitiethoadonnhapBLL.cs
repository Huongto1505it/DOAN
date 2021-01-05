using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class ChitiethoadonnhapBLL : IChitiethoadonnhapBLL
    {
        private IChitiethoadonnhapDAL mhdal = new ChitiethoadonnhapDAL();
        public List<Chitiethoadonnhap> GetALLMH()
        {
            return mhdal.GetAllChitiethoadonnhap();
        }
        public void themChitiethoadonnhap(List<Mathang> h, Chitiethoadonnhap mh)
        {
            if (mh.Soluong >= 0)
            {
                mhdal.ThemChitiethoadonnhap(h, mh);
            }
            else Console.WriteLine("Du lieu sai");
        }
        public void SuaChitiethoadonnhap(Chitiethoadonnhap mh)
        {
            int i;
            List<Chitiethoadonnhap> MH = mhdal.GetAllChitiethoadonnhap();
            for (i = 0; i < MH.Count; i++)
                if (MH[i].Mamh == mh.Mamh) break;

            if (i <= MH.Count)
            {
                MH.RemoveAt(i);
                MH.Add(mh);
                mhdal.CapnhatChitiethoadonnhap(MH);

            }
            else
                throw new Exception("Khong ton tai mat hang nay");
        }
        public void XoaChitiethoadonnhap(string Mamh)
        {
            int i;
            List<Chitiethoadonnhap> MH = mhdal.GetAllChitiethoadonnhap();
            for (i = 0; i < MH.Count; i++)
            {
                if (MH[i].Mamh == Mamh) break;
            }
            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                mhdal.CapnhatChitiethoadonnhap(MH);
            }
            else
                throw new Exception("Khong ton tai mat hang nay");
        }
    }
}

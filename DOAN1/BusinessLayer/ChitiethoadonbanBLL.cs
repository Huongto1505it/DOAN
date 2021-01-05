using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class ChitiethoadonbanBLL : IChitiethoadonbanBLL
    {
        private IChitiethoadonbanDAL mhdal = new ChitiethoadonbanDAL();
        public List<Chitiethoadonban> GetALLMH()
        {
            return mhdal.GetAllChitiethoadonban();
        }
        public void themChitiethoadonban(List<Mathang> h, Chitiethoadonban mh)
        {
            if (mh.Soluong >= 0)
            {
                mhdal.ThemChitiethoadonban(h, mh);
            }
            else Console.WriteLine("Dữ liệu không đúng");
        }
        public void SuaChitiethoadonban(Chitiethoadonban mh)
        {
            int i;
            List<Chitiethoadonban> MH = mhdal.GetAllChitiethoadonban();
            for (i = 0; i < MH.Count; i++)
                if (MH[i].Mamh == mh.Mamh) break;

            if (i <= MH.Count)
            {
                MH.RemoveAt(i);
                MH.Add(mh);
                mhdal.CapnhatChitiethoadonban(MH);

            }
            else
                throw new Exception("Khong ton tai mat hang nay");
        }
        public void XoaChitiethoadonban(string Mamh)
        {
            int i;
            List<Chitiethoadonban> MH = mhdal.GetAllChitiethoadonban();
            for (i = 0; i < MH.Count; i++)
            {
                if (MH[i].Mamh == Mamh) break;
            }
            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                mhdal.CapnhatChitiethoadonban(MH);
            }
            else
                throw new Exception("Khong ton tai mat hang nay");
        }
    }
}

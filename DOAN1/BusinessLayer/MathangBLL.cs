using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
   public class MathangBLL:IMathangBLL
    {
        private IMathangDAL mhdal=new MathangDAL();
        public List<Mathang> GetALLMH()
        {
            return mhdal.GetAllMathang();
        }
        public void themmathang(Mathang mh)
        {
            if (mh.Tenmh !="")
            {
                mhdal.ThemMathang(mh);
            }
            else Console.WriteLine("Du lieu sai");
        }
        public void SuaMathang(Mathang mh)
        {
            int i;
            List<Mathang> MH =mhdal.GetAllMathang();
            for( i = 0; i < MH.Count; i++)
                if (MH[i].Mamh == mh.Mamh) break;
            
            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                MH.Add(mh);
               mhdal.CapnhatMathang(MH);
            }
            else
                throw new Exception("Khong ton tai mat hang nay");
        }
        public void XoaMathang(string Mamh)
        {
            int i;
            List<Mathang> MH = mhdal.GetAllMathang();
            for (i = 0; i < MH.Count; i++)
            {
                if (MH[i].Mamh == Mamh) break;
            }
            if (i < MH.Count)
            {
                MH.RemoveAt(i);
                mhdal.CapnhatMathang(MH);
            }
            else
                throw new Exception("Khong ton tai mat hang nay");
        }
        public List<Mathang> Timkiemmathang(Mathang mh)
        {
            List<Mathang> list = mhdal.GetAllMathang();
            List<Mathang> MH = new List<Mathang>();
            if(string.IsNullOrEmpty(mh.Mamh) && string.IsNullOrEmpty(mh.Tenmh) && string.IsNullOrEmpty(mh.Theloai))
            {
                MH = list;
            }
            if (!string.IsNullOrEmpty(mh.Mamh))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Mamh.IndexOf(mh.Mamh) >= 0)
                    {
                        MH.Add(new Mathang(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(mh.Tenmh))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tenmh.IndexOf(mh.Tenmh) >= 0)
                    {
                        MH.Add(new Mathang(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(mh.Theloai))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Theloai.IndexOf(mh.Theloai) >= 0)
                    {
                        MH.Add(new Mathang(list[i]));
                    }
                }
            }
            
            
            return MH;
        }
    }
}

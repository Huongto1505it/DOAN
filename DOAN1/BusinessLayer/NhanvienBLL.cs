using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;
namespace DOAN1.BusinessLayer
{
    public class NhanvienBLL : INhanvienBLL
    {
        private INhanvienDAL nvdal = new NhanvienDAL();
        public List<Nhanvien> GetALLMH()
        {
            return nvdal.GetAllNhanvien();
        }
        public void themNhanvien(Nhanvien nv)
        {
            if (nv.Tennv != "")
            {
                nvdal.ThemNhanvien(nv);
            }
            else Console.WriteLine("Du lieu sai");
        }
        public void SuaNhanvien(Nhanvien nv)
        {
            int i;
            List<Nhanvien> nvlist = nvdal.GetAllNhanvien();
            for (i = 0; i < nvlist.Count; i++)
                if (nvlist[i].Manv == nv.Manv) break;

            if (i < nvlist.Count)
            {
                nvlist.RemoveAt(i);
                nvlist.Add(nv);
                nvdal.CapnhatNhanvien(nvlist);
            }
            else
                throw new Exception("Khong ton tai nhan vien nay");
        }
        public void XoaNhanvien(string Manv)
        {
            int i;
            List<Nhanvien> nvlist = nvdal.GetAllNhanvien();
            for (i = 0; i < nvlist.Count; i++)
            {
                if (nvlist[i].Manv == Manv) break;
            }
            if (i < nvlist.Count)
            {
                nvlist.RemoveAt(i);
                nvdal.CapnhatNhanvien(nvlist);
            }
            else
                throw new Exception("Khong ton tai ma nhan vien nay");
        }
        public List<Nhanvien> TimkiemNhanvien(Nhanvien nv)
        {
            List<Nhanvien> list = nvdal.GetAllNhanvien();
            List<Nhanvien> MH = new List<Nhanvien>();
            if (string.IsNullOrEmpty(nv.Manv) && string.IsNullOrEmpty(nv.Tennv) && string.IsNullOrEmpty(nv.Diachi))
            {
                MH = list;
            }
            if (!string.IsNullOrEmpty(nv.Manv))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Manv.IndexOf(nv.Manv) >= 0)

                        MH.Add(new Nhanvien(list[i]));
                }
            }

            else if (!string.IsNullOrEmpty(nv.Tennv))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tennv.IndexOf(nv.Tennv) >= 0)
                    {
                        MH.Add(new Nhanvien(list[i]));
                    }
                }
            }
            else if (!string.IsNullOrEmpty(nv.Diachi))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tennv.IndexOf(nv.Diachi) >= 0)
                    {
                        MH.Add(new Nhanvien(list[i]));
                    }
                }
            }
            return MH;
        }
    }
}
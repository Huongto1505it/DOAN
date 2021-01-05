using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface INhanvienDAL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemNhanvien(Nhanvien kh);
        void CapnhatNhanvien(List<Nhanvien> kh);
    }
}

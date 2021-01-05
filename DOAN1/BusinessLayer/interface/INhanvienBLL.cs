using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.BusinessLayer
{
    public interface INhanvienBLL
    {
        List<Nhanvien> GetALLMH();
        void themNhanvien(Nhanvien nv);
        void SuaNhanvien(Nhanvien nv);
        void XoaNhanvien(string Manv);
        List<Nhanvien> TimkiemNhanvien(Nhanvien nv);

    }
}

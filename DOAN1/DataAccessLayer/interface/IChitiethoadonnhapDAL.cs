using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;
namespace DOAN1.DataAccessLayer
{
    public interface IChitiethoadonnhapDAL
    {
        List<Chitiethoadonnhap> GetAllChitiethoadonnhap();
        void ThemChitiethoadonnhap(List<Mathang> h, Chitiethoadonnhap mh);
        void CapnhatChitiethoadonnhap(List<Chitiethoadonnhap> MH);

    }
}
